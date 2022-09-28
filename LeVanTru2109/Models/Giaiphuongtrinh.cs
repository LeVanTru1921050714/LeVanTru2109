using Microsoft.AspNetCore.Mvc;

namespace LeVanTru2109.Models
{
    public class Giaiphuongtrinh
        // Cac buoc khai bao 1 phuong thuc
        // 1, Xac dinh kieu tra ve cua phuong trinh
        //2. Xac dinh cac tham so dau vao cua phuong trinh
        // xay dung phan than phuong thuc
        // Tra ve du lieu tuong ung
        //3. Xay dung view de gui du lieu tu view len controller
        //4. Xay dung Action de nhan du lieu tu view
        // - So luong cac tham so cua Action
        // - Kieu du lieu va ten cua cac tham so
        // - Trung ten th input tren view
        //5. Goi thuc thi phuognt huc trong Controller
        // - Using namespace
        // Khai bao class theo huong doi tuong
        // Goi thuc the cac phuong thuc trong class
    {
        // Xay dung Phuong thuc giai phuong trinh bac nhat
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            // tinh nghiem cua phuong trinh
            // 1, khai bao bien
            double x;
            string message = "";
            // gan gia tri tu view gui len

            //double heSoA = Convert.ToDouble(heSoA);
            //double heSob = double.Parse(heSoB);
            //3. Giai phuong trinh
            if (heSoA == 0)
            {
                if (heSoB == 0)
                {
                    message = "Phuong trinh co vo so nghiem";
                }
                else
                {
                    message = "Phuong trinh vo nghiem";
                }
            }
            else
            {
                x = -heSoB / heSoA;
                message = "Phuong trinh co nghiem x = " +x;
            }
            return message;
        }
        // Giai phuong trinh Bac2
        public string GiaiphuongtrinhBacHai(double heSoA, double heSoB, double heSoC)
        {
            string thongBao = "";
            double delta, x1, x2, x;
            if (heSoA == 0)
            {
                //Giai phuong trinh bac nhat
                thongBao = GiaiphuongtrinhBacHai(heSoB, heSoC);

                if (heSoB == 0)
                {
                    if (heSoC == 0)
                    {
                        thongBao = "phuong trinh co vo so nghiem";
                    }
                    else
                    {

                        thongBao = "phuong trinh vo nghiem";
                    }
                }


                else
                {
                    x = -heSoC / heSoB;
                    thongBao = " phuong trinh co nghiem x :" + x;
                }
            }


            else
            {
                delta = heSoB * heSoB - 4 * heSoA * heSoC;
                // tinh nghiệm
                if (delta > 0)
                {
                    x1 = (-heSoB + Math.Sqrt(delta)) / 2 * heSoA;
                    x2 = (-heSoB - Math.Sqrt(delta)) / 2 * heSoA;
                    thongBao = "phuong trinh co 2 nghiem x1 và x2 là: " + x1 + " va " + x2;

                }
                else if (delta == 0)
                {
                    x = -heSoB / (2 * heSoA);
                    thongBao = "Phuong trinh co nghiem kep x1 = x2 = " + x;

                }
                else
                {
                    thongBao = "Phương trinh Vo nghiem";
                }


            }
            return thongBao;

        }

        private string GiaiphuongtrinhBacHai(double heSoB, double heSoC)
        {
            throw new NotImplementedException();
        }
    }
}
