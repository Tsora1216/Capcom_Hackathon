using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Collections.Specialized;
public class Hello
{
    static void Main(string[] args)
    {
        //「2」「4」が実引数
        var num = Test(2, 4);
        System.Console.WriteLine(num);
    }

    //「num1」「num2」が仮引数
    //メソッドの実行時に「2」と「4」の値が入る
    static int Test(int num1, int num2)
    {
        using System.Text;
        using System.Web;
        using System.Net;
        using System.IO;

        Encoding encode = Encoding.GetEncoding(“UTF - 8”);
        string postStr = “param1 =” +HttpUtility.UrlEncode(“第一パラメーター”, encode)
        + “&param2 =” +HttpUtility.UrlEncode(“第二パラメーター”, encode);
        byte[] postBytes = Encoding.ASCII.GetBytes(postStr);

        WebRequest request = WebRequest.Create(“http://（どこかのWebサイトのURL）”);
        request.Method = “POST”;
        request.ContentLength = postBytes.Length;
        request.ContentType = “application / x - www - form - urlencoded”;
        Stream reqStream = request.GetRequestStream();
        // 送信する
        reqStream.Write(postBytes, 0, postBytes.Length);
        reqStream.Close();
        // 受信する
        WebResponse response = request.GetResponse();
        Stream resStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(resStream, encode);
        Console.WriteLine(reader.ReadToEnd());
        reader.Close();
    }
}