using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Gettingstart
{
    internal static class Service
    {
        // lấy các account từ file ra, phương thức này trả về 1 lsst account
        public static List<account> GetallAcounts()
        {
            List<account> accounts = new List<account>(); // khởi tạo list để chứa
            // lấy data từ file account.txt đã được tạo ra 1 mảng string, mỗi dòng là 1 account
            string[] datas = File.ReadAllLines("account.txt");
            foreach (string data in datas) // xử lý mỗi dòng lấy được thành một account
            {
                if (!string.IsNullOrEmpty(data)) // nếu chuỗi không rỗng
                {
                    //cắt chuỗi ra thành từng thuộc tính riêng biệt
                    string[] thuoctinhs = data.Split('|'); // cắt theo gạch |
                    // tạo đối tượng từ thuộc tính và thu được
                    string name = thuoctinhs[0];
                    string address = thuoctinhs[1];
                    string username = thuoctinhs[2];
                    string password = thuoctinhs[3];
                    string phone = thuoctinhs[4];
                    bool gt = thuoctinhs[5] == "true";
                    DateTime dob = Convert.ToDateTime(thuoctinhs[6]);
                    string imgPath = thuoctinhs[7];
                    account account = new account(name,address,username,password,phone,gt,dob,imgPath);
                    accounts.Add(account); // thêm account vừa lấy được vào list để trả về
                }
            }
            return accounts; // trả về danh sách
        }        
        // kiểm tra account nhập vào từ form đăng nhập có nằm trong danh sách account ko
        public static account CheckLogin(string username, string password)
        {
            var allAccounts = GetallAcounts(); // lấy danh sách từ file txt
            var check = allAccounts.FirstOrDefault(p => p.username == username && p.password == password); //linq vs lamba expression
            var check2 = from account in allAccounts
                         where account.username == username && account.password == password
                         select account; // thuần linq
            return check; //trả về check, nếu check không được tìm thấy thì nó vẫn là null
        }
        // khi mà account được sác nhận là có tồn tại thì ta trả về một đối tượng account
        //kiểm tra xem account có bị trùng hay không khi thêm mới (đăng kí)
    }
}
