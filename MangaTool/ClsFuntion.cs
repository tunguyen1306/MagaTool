
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace YLProject.AppCode
{
    public static class ClsFuntion
    {

      

       
        public static string Login_VS(string user_name, string user_pass)
        {
            string rs_ = EncodePassword(user_name).Replace("-", "") + "code@vuisam.vn" + EncodePassword(user_pass).Replace("-", "");
            return EncodePassword(rs_).Replace("-", "");
        }
        public static string Confom_Email_VS(string user_name, string user_email)
        {
            string rs_ = EncodePassword(user_name).Replace("-", "") + "email@vuisam.vn" + EncodePassword(user_email).Replace("-", "");
            return EncodePassword(rs_).Replace("-", "");
        }
        public static string random_Pass()
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#!@#!@#";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 12)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        public static string random_Key()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 10)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        public static string EncodePassword(string code_change)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(code_change);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }
      
        public static void write_file_chat(string file_name, string folder_link, string line_chat, string user_id)
        {
            try
            {
                //Lấy đường dẫn full 
                string newPath = System.IO.Path.Combine(folder_link, file_name);

                if (File.Exists(newPath)) //file tồn tại
                {
                    //Có file thì ghi thêm
                    File.AppendAllText(newPath, line_chat);
                }
                else
                {
                    //ko có file thì tạo file
                    FileStream fs = null;
                    using (fs = File.Create(newPath))
                    {
                    }
                    File.AppendAllText(newPath, line_chat);
                }
            }
            catch (Exception ex)
            {
               
            }

        }
     

        public static string build_page_index(int page_index, int total_page, string link_root, int page_max_show)
        {
            string rs = "<ul>";
            string for_page = "<li><a href='{0}'>{1}</a></li>";
            string page_current = "<li class='currentpage'>{0}</li>";

            //====================== Bắt đầu thuật giải tính số trang bắt đầu và số trang cuối ==============//
            ////Tổng số trang có thể click


            //Mục đích cho số trang dc chọn luôn ở giữa
            int page_begin = 1;//Số liệu mẫu
            int page_max = 4;//Số liệu mẫu
            if (total_page > page_max_show)
            {
                if (page_index <= (page_max_show - 1) / 2)
                {
                    //Là tràng đầu nhỏ hơn trang tối đa / 2
                    page_begin = 1;
                    page_max = page_max_show;
                }
                else
                {
                    //Lớn hơn số lượng page mặc định
                    if (total_page > page_index + (page_max_show - 1) / 2)
                    {
                        //Nếu số trang tổng nhiều hơn trang đang đứng là tối đa - 1 / 2
                        page_begin = page_index - (page_max_show - 1) / 2;
                        page_max = page_index + (page_max_show - 1) / 2;
                    }
                    else
                    {
                        //Trang hiện tại không thể canh giữa được nữa
                        //Vậy là tính max
                        page_begin = total_page - page_max_show;
                        page_max = total_page;
                    }
                }
            }
            else
            {
                //Nhỏ quá nên show ra hết
                page_begin = 1;
                page_max = total_page;
            }
            //====================== Kết thúc thuật giải ==============//

            //Có nhiều trang để phân
            for (int i = page_begin; i <= page_max; i++)
            {
                if (i == page_begin)//Lập ở vị trí đầu tiên
                {
                    if (page_index == 1)//Nếu là trang 1 thì trước là ko cho click
                    {
                        rs += "<li class='disablepage'>Đầu</li>";
                        rs += "<li class='disablepage'>Trước</li>";
                    }
                    else
                    {
                        rs += "<li class='nextpage'><a href='" + link_root + "/1'>Đầu</a></li>";
                        rs += "<li class='nextpage'><a href='" + link_root + "/" + (page_index - 1).ToString() + "'>Trước</a></li>";
                    }
                }
                //Lập ở vị trí các trang bất kỳ
                if (page_index == i)
                    rs += String.Format(page_current, i.ToString());
                else
                    rs += String.Format(for_page, link_root + "/" + i.ToString(), i.ToString());

                if (i == page_max)//Lập ở vị trí cuối cùng
                {
                    if (page_index == total_page)//Trang cuối cùng thì không click
                    {
                        rs += "<li class='disablepage'>Sau</li>";
                        rs += "<li class='disablepage'>Cuối</li></ul>";
                    }
                    else
                    {
                        rs += "<li class='nextpage'><a href='" + link_root + "/" + (page_index + 1).ToString() + "'>Sau</a></li>";
                        rs += "<li class='nextpage'><a href='" + link_root + "/" + total_page.ToString() + "'>Cuối</a></li></ul>";
                    }
                }
            }
            return rs;
        }

        /// <summary>
        /// Xác định nhóm sản phẩm từ tên sản phẩm và id sản phẩm
        /// </summary>
        /// <param name="product"></param>
        /// <param name="id_product"></param>
        /// <returns></returns>
        public static string get_cat_product(string product, int id_product)
        {
            return "";
        }

        /// <summary>
        /// Chỉ cần tên sản phẩm và mã số sản phẩm định ra được tên template của người tạo
        /// </summary>
        /// <param name="product"></param>
        /// <param name="id_product"></param>
        /// <returns></returns>
        public static string get_tamplate(string product, int id_product)
        {
            return "";
        }
     
        public static string chang_to_sexy_key(string c_url)
        {
            c_url = c_url.ToLower();
            c_url = Regex.Replace(c_url, @" +", " ");
            c_url = c_url.Trim();
            c_url = Convert_Chuoi_Khong_Dau(c_url);
            return c_url;
        }
        public static string chang_to_sexy_san_pham(string c_url)
        {
            c_url = Regex.Replace(c_url, @" +", " ");
            return c_url;
        }
        public static string key_for_img(string c_url)
        {
            c_url = c_url.ToLower();
            c_url = Regex.Replace(c_url, @" +", "-").Replace(",", "-");
            c_url = c_url.Trim();
            c_url = Convert_Chuoi_Khong_Dau(c_url);
            return c_url;
        }
        public static string create_forder_movies_by_key(string key, string path)
        {
            AA:
            if (!Directory.Exists(path + "/" + key))
            {
                Directory.CreateDirectory(path + "/" + key);
               
            }
            else
            {
                key += "1";
                goto AA;
            }
            return key;
        }
        /// <summary>
        /// Xoá file trên thu mục của user đó
        /// </summary>
        /// <param name="file_name"></param>
        /// <param name="url_local"></param>
        /// <returns></returns>
        public static Boolean del_file(string file_name, string url_local)
        {
            try
            {
                File.Delete(url_local + "\\" + file_name);
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Tạo thư mục cho người dùng mua bán
        /// </summary>
        /// <param name="folder_name"></param>
        /// <param name="url_local"></param>
        /// <returns></returns>
        public static Boolean create_folder(string folder_name, string url_local)
        {
            try
            {
                File.Delete(url_local + "\\" + folder_name);
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Thay đổi định dạng khoản cách giữa các từ
        /// </summary>
        /// <param name="c_url"></param>
        /// <returns></returns>
        public static string config_url(string c_url)
        {
            c_url = c_url.ToLower();
            c_url = Regex.Replace(c_url, @" +", " ");
            c_url = c_url.Trim();
            c_url = c_url.Replace(" ", "-");
            c_url = Convert_Chuoi_Khong_Dau(c_url);
            return c_url;
        }
        public static string del_span_text(string c_text)
        {
            c_text = Regex.Replace(c_text, @" +", "");
            c_text = c_text.Trim();
            return c_text;
        }
        /// <summary>
        /// Định dạng chuỗi có dấu thành không dấu
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Convert_Chuoi_Khong_Dau(string s)
        {
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
       
    }
}
