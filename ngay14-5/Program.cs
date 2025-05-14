namespace ngay14_5
{   /*
    internal class Program
    {
        static void Main(string[] args)
        {  
            //in ra màn hình nhưng không xuống dòng
            Console.Write("khong xuong dong");
            //in ra màn hình rồi xuống dòng
            Console.WriteLine("in ra roi xuong dong");
            //nhập xong không xuống dòng
            string name;
            // Console.Read()
            name = Console.ReadLine();
            //nhập xong xuống dòng 
            Console.WriteLine(name);

            //biến
            int kieu_so_nguyen;
            float kieu_so_thuc;
            string kieu_chuoi;
            bool kieu_logic;
            char kieu_ki_tu;
            //if else
            Console.Write("nhap diem: ");
            int diem = int.Parse(Console.ReadLine());

            if (diem >= 90)
                Console.WriteLine("Gioi");
            else if (diem >= 70)
                Console.WriteLine("Kha");
            else
                Console.WriteLine("Trung binh");
            //swtich case
           
            Console.Write("nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Quy 1");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Quy 2");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Quy 3");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Quy 4");
                    break;
                default:
                    Console.WriteLine("Không xác định");
                    break;
            }
           
            //for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lan lap thu: " + i);
            }
             
            //While
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine("lan lap: " + i);
                i++;
            }
            
            //Do while
            int i = 1;

            do
            {
                Console.WriteLine("lan lap: " + i);
                i++;
            }
            while (i <= 5);
            
            //Array
            int[] diem = { 7, 8, 9, 10, 6 };
            //mảng 2 chiều 
            int[,] a =
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };
            
            //in và nhập mảng 2 chièu
            Console.Write("nhap so dong : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("nhap so cot: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];
            NhapMang(a, m, n);
            XuatMang(a, m, n);




        }
        static void NhapMang(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void XuatMang(int[,] a, int m, int n)
        {
            Console.WriteLine("Ma tran la:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        }
    }
     */

    // Interface
    interface IKeu
    {
        void Keu();
    }

    // Lớp trừu tượng
    abstract class DongVat
    {
        // Field riêng (đóng gói)
        private string ten;

        // Property (thuộc tính truy cập)
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        // Constructor
        public DongVat(string ten)
        {
            this.ten = ten;
            Console.WriteLine($"[Constructor] {ten} được tạo.");
        }

        // Destructor
        ~DongVat()
        {
            Console.WriteLine($"[Destructor] {ten} bị hủy.");
        }

        // Phương thức trừu tượng
        public abstract void DiChuyen();

        // Phương thức bình thường
        public virtual void An()
        {
            Console.WriteLine($"{Ten} đang ăn...");
        }
    }

    // Lớp Meo kế thừa từ DongVat và triển khai IKeu
    class Meo : DongVat, IKeu
    {
        public Meo(string ten) : base(ten) { }

        public override void DiChuyen()
        {
            Console.WriteLine($"{Ten} đi nhẹ nhàng bằng 4 chân.");
        }

        public void Keu()
        {
            Console.WriteLine($"{Ten} kêu: Meo meo!");
        }
    }

    // Lớp Cho kế thừa từ DongVat và triển khai IKeu
    class Cho : DongVat, IKeu
    {
        public Cho(string ten) : base(ten) { }

        public override void DiChuyen()
        {
            Console.WriteLine($"{Ten} chạy nhanh bằng 4 chân.");
        }

        public void Keu()
        {
            Console.WriteLine($"{Ten} kêu: Gâu gâu!");
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đối tượng
            Meo meo = new Meo("Tom");
            Cho cho = new Cho("Lu");

            // Gọi các phương thức
            meo.An();
            meo.DiChuyen();
            meo.Keu();

            Console.WriteLine();

            cho.An();
            cho.DiChuyen();
            cho.Keu();

            // Đợi người dùng để xem kết quả
            Console.WriteLine("\nNhấn Enter để thoát...");
            Console.ReadLine();
        }
    }

}
