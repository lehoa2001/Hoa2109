namespace Hoa2109.Models.Process
{
    public class GiaiPhuongTrinh
    {
        //xây dựng các phương thức
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            //khai báo 1 biến để chứa dữ liệu muốn trả về
            string thongBao = "";
            //khai báo 1 biến số để chứa giái trị nghiệm của phương trình
            double x;
            //giải phương trình
            if(heSoA == 0){
                if(heSoB == 0) {
                    thongBao = "Phương trình có vô số nghiệm";
                }
                else{
                    thongBao = "Phương trình vô nghiệm";
                }
            }else {
                //tính nghiệm của phương trình bậc nhất
                x = -heSoB/heSoA;
                thongBao = "Phương trình có nghiệm x = " + x;
            }
            //trả về dữ liệu
            return thongBao;

        }
    }
}