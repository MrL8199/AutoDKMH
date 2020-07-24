using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace AutoDKMH
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Register(string requestBody)
        {
            lblStatus.Text = "Đăng ký..";
            var client = new RestClient("http://dangkyhoc.mta.edu.vn/Register/RegisterUnder.asp?command=update");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Host", "dangkyhoc.mta.edu.vn");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cache-Control", "max-age=0");
            request.AddHeader("Origin", " http://dangkyhoc.mta.edu.vn");
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            request.AddHeader("DNT", "1");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.89 Safari/537.36";
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Referer", "http://dangkyhoc.mta.edu.vn/Register/RegisterUnder.asp");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Accept-Language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
            request.AddHeader("Cookie", tbCookiesKey.Text + "=" + tbCookiesValue.Text);
            request.AddCookie(tbCookiesKey.Text, tbCookiesValue.Text);
            request.AddParameter("application/x-www-form-urlencoded", requestBody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            lblStatus.Text = "Xong..";
        }

        private void Login()
        {
            lblStatus.Text = "Đăng nhập..";
            try
            {
                var client = new RestClient("http://dangkyhoc.mta.edu.vn/dkmh/login.asp");
                client.Timeout = -1;
                client.FollowRedirects = false;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Host", "dangkyhoc.mta.edu.vn");
                request.AddHeader("Cache-Control", " max-age=0");
                request.AddHeader("Origin", " http://dangkyhoc.mta.edu.vn");
                request.AddHeader("Upgrade-Insecure-Requests", " 1");
                request.AddHeader("DNT", " 1");
                request.AddHeader("Content-Type", " application/x-www-form-urlencoded");
                client.UserAgent = " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.89 Safari/537.36";
                request.AddHeader("Accept", " text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                request.AddHeader("Referer", " http://dangkyhoc.mta.edu.vn/dkmh/login.asp");
                request.AddHeader("Accept-Encoding", " gzip, deflate");
                request.AddHeader("Accept-Language", " vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
                request.AddHeader("Cookie", tbCookiesKey.Text + "=" + tbCookiesValue.Text);
                request.AddParameter(" application/x-www-form-urlencoded", "chkSubmit=ok&txtLoginId=" + tbID.Text + "&txtPassword=" + tbPassword.Text + "&txtSel=1", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                //tbCookiesKey.Text = response.Cookies.SingleOrDefault(x => x.Name.Contains("ASP")).Name.ToString();
                //tbCookiesValue.Text = response.Cookies.SingleOrDefault(x => x.Name.Contains("ASP")).Value.ToString();
                File.WriteAllText("account.txt", tbID.Text + "|" + tbPassword.Text);
                File.WriteAllText("cookies.txt", tbCookiesKey.Text+"|"+tbCookiesValue.Text);
                lblStatus.Text = "Đăng nhập thành công";
            }
            catch (Exception)
            {
                lblStatus.Text = "Lỗi đăng nhập";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            GetListSubjects();
            StringBuilder reqBody = new StringBuilder();
            BuildRequestBody(reqBody);
            for (int i = 0; i < 10; i++)
            {
                Register(reqBody.ToString());
            }
        }

        private void appendResquestBody(StringBuilder resBody, string param, List<string> listParam)
        {
            resBody.Append(@"&"+param+"=");
            foreach (string parameterID in listParam)
            {
                resBody.Append(@",");
                resBody.Append(parameterID);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("cookies.txt"))
            {
                File.Create("cookies.txt");
            }
            tbCookiesKey.Text = File.ReadAllText("cookies.txt").Split('|')[0];
            tbCookiesValue.Text = File.ReadAllText("cookies.txt").Split('|')[1];
            if (!File.Exists("account.txt"))
            {
                File.Create("account.txt");
            }
            tbID.Text = File.ReadAllText("account.txt").Split('|')[0];
            tbPassword.Text = File.ReadAllText("account.txt").Split('|')[1];
            tbListSubjects.Text = File.ReadAllText("subjects.txt");
        }

        private void timerAntiTimeoutSession_Tick(object sender, EventArgs e)
        {
            Login();
        }

        private void GetListSubjects()
        {
            lblStatus.Text = "Lấy danh sách môn học..";
            int subNum = 0;
            var client = new RestClient("http://dangkyhoc.mta.edu.vn/Register/RegisterTab.asp?selViewType=All");
            if (cbByMajor.Checked)
            {
                client = new RestClient("http://dangkyhoc.mta.edu.vn/Register/RegisterTab.asp?selViewType=ByMajor");
            }
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddCookie(tbCookiesKey.Text, tbCookiesValue.Text);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(response.Content);
            var htmlNodes = document.DocumentNode.SelectNodes("//*[@name=\"hidCseCode\"]");

            int i = 0;
            foreach(var node in htmlNodes)
            {
                if (tbListSubjects.Text.Contains(node.Attributes["value"].Value))
                {
                    string CSE_ID = document.DocumentNode.SelectNodes("//*[@name=\"hidCSE_ID\"]").ElementAt(htmlNodes.GetNodeIndex(node)).Attributes["value"].Value;
                    string hidCRD_ID = document.DocumentNode.SelectNodes("//*[@name=\"hidCRD_ID\"]").ElementAt(htmlNodes.GetNodeIndex(node)).Attributes["value"].Value;
                    string hidLichhoc = document.DocumentNode.SelectNodes("//*[@name=\"hidLichhoc\"]").ElementAt(htmlNodes.GetNodeIndex(node)).Attributes["value"].Value;
                    string hidNumCrd = document.DocumentNode.SelectNodes("//*[@name=\"hidNumCrd\"]").ElementAt(htmlNodes.GetNodeIndex(node)).Attributes["value"].Value;

                    tbCSE_ID.Text += "," + CSE_ID;
                    tbhidListReg.Text += CSE_ID + ",";
                    tbCRD_ID.Text += "," + hidCRD_ID;
                    tbLichhoc.Text += "," + hidLichhoc;
                    subNum += Convert.ToInt32(hidNumCrd);
                    tbhidSubNum.Text = subNum.ToString();
                }
                //Console.WriteLine(node.Attributes["value"].Value);
                i++;
            }
            File.WriteAllText("subjects.txt", tbListSubjects.Text);
            lblStatus.Text = "Lấy danh sách môn học xong..";
        }

        private void BuildRequestBody(StringBuilder reqBody)
        {
            reqBody.Append("hidSortBy=1&hidCseChoice=");
            reqBody.Append(tbCSE_ID.Text);
            reqBody.Append("&hidCrdChoice=" + tbCRD_ID.Text);
            reqBody.Append("&hidTimeChoice=" + tbLichhoc.Text);
            reqBody.Append("&hidLengthArrUnder="+ (tbListSubjects.Text.Split(',').Length-1) + "&hidListRegOld=&hidListReg=");
            reqBody.Append(tbhidListReg.Text.Remove(tbhidListReg.Text.Length-1));
            reqBody.Append("&hidSubNum=" + tbhidSubNum.Text);

            for (int i = 0; i < tbListSubjects.Text.Split(',').Length; i++)
            {
                reqBody.Append("&hidCRD_ID=&hidCSE_ID" + i + "=" + tbhidListReg.Text.Split(',')[i] + "&hidNumCse=&hidBrc1" + i + "=0&hidValueCheckBrc1" + i + "=1&hidBrc2" + i + "=0&hidValueCheckBrc2" + i + "=0&hidTypeReg" + i+"=0");
            }

            reqBody.Append("&txtSubNum=&txtNumCrd=");
            reqBody.Replace(",", "%2C");
            reqBody.Replace(":", "%3A");
        }
    }
}
