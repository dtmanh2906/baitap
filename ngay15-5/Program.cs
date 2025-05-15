using System;
using System.Net.NetworkInformation;

namespace ngay15_5

{
    /*bai 1  :Đầu tiên tạo một project mới. Sau đó, tạo 3 class: Person, Teacher, Student, trong đó hai lớp Teacher và Student kế thừa lớp Person.
    Bạn có thể tùy ý tạo các thuộc tính và các phương thức cho các lớp này.Chẳng hạn: lớp Person có phương thức setAge(int age),
    lớp Student có phương thức GoToClass() để in ra thông báo I'm going to class., ...
    class Person
    {
        public string Name { get; set; }
        public int Age { get; private set; }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Chao ban toi ten la {Name} va toi {Age} tuoi.");
        }
    }

    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Bat dau giang bai.");
        }
    }

    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("toi dang den lop");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nhập thông tin cho học sinh
            Console.WriteLine("Nhap thong tin hoc sin");
            Console.Write("Nhap ten: ");
            string studentName = Console.ReadLine();
            Console.Write("nhap tuoi: ");
            int studentAge = int.Parse(Console.ReadLine());

            Student student = new Student();
            student.Name = studentName;
            student.SetAge(studentAge);
            student.Introduce();
            student.GoToClass();

            Console.WriteLine();

            // Nhập thông tin cho giáo viên
            Console.WriteLine("nhap thong tin giao vien :");
            Console.Write("nhap ten :  ");
            string teacherName = Console.ReadLine();
            Console.Write("nhap tuoi :  ");
            int teacherAge = int.Parse(Console.ReadLine());

            Teacher teacher = new Teacher();
            teacher.Name = teacherName;
            teacher.SetAge(teacherAge);
            teacher.Introduce();
            teacher.Explain();
        }
    }*/
    //bai 2  Tự phát sinh ra n con vật thuộc 3 kiểu vịt, cừu và bò.
    /*1Thủ tục phát sinh như sau:
        +Phát sinh ngẫu nhiên số n
        +Lặp tự 1 đến n, mỗi lần lại ngẫu nhiên sinh ra một con vật thuộc 1 trong 3 kiểu vịt, cừu, bò.
        +Thống kê đã sinh ra bao nhiêu con mỗi loại.
    2.Một hôm Mc Donald đi vắng, tất cả gia súc trong nông trại đều đói.Hãy cho biết những tiếng kêu nghe được trong nông trại.
    3.Chỉ có bò mới có thể cho sữa. Hãy duyệt qua mảng một lần để vắt sữa (nếu đó là con bò)
    và thống kê số lượng sữa thu được, biết số lít sữa bò cho là ngẫu nhiên trong khoảng từ 0 đến 20 lít.
    Vì tất cả đều là con cái nên lần lượt duyệt qua toàn bộ mảng và gọi hàm sinh để thêm vào mảng các con vật mới
    (giả sử khi hàm sinh được gọi thì ta có luôn một con non). Biết số con sinh được là ngẫu nhiên trong khoảng từ 0-4.
    */
 
    
        abstract class Gia_Suc
        {
            public abstract string Keu_Len();

            public virtual int Cho_Sua()
            {
                return 0;
            }

            public virtual List<Gia_Suc> Sinh_Con(Random ngau_Nhien)
            {
                int so_Con = ngau_Nhien.Next(0, 5); // Từ 0 đến 4 con
                List<Gia_Suc> ds_Con = new List<Gia_Suc>();
                for (int i = 0; i < so_Con; i++)
                {
                    ds_Con.Add(this.Sao_Chep());
                }
                return ds_Con;
            }

            public abstract Gia_Suc Sao_Chep();
        }

        class Vit : Gia_Suc
        {
            public override string Keu_Len() => "quac quac";
            public override Gia_Suc Sao_Chep() => new Vit();
        }

        class Cuu : Gia_Suc
        {
            public override string Keu_Len() => "be be";
            public override Gia_Suc Sao_Chep() => new Cuu();
        }

        class Bo : Gia_Suc
        {
            public override string Keu_Len() => "quac quac";
            public override int Cho_Sua()
            {
                Random ngau_Nhien = new Random();
                return ngau_Nhien.Next(0, 21); // 0–20 lít
            }

            public override Gia_Suc Sao_Chep() => new Bo();
        }

    class ChuongTrinh
    {
        static void Main(string[] args)
        {
            Random ngau_Nhien = new Random();
            int so_Luong;

            Console.Write("nhap so luong gia suc: ");
            while (!int.TryParse(Console.ReadLine(), out so_Luong) || so_Luong <= 0)
            {
                Console.Write("vui long nhap so nguyen duong: ");
            }

            List<Gia_Suc> danh_Sach_Gia_Suc = new List<Gia_Suc>();
            int so_Vit = 0, so_Cuu = 0, so_Bo = 0;

            // Phát sinh n con gia súc ngẫu nhiên
            for (int i = 0; i < so_Luong; i++)
            {
                int loai = ngau_Nhien.Next(3); // 0: Vịt, 1: Cừu, 2: Bò
                Gia_Suc con;
                if (loai == 0)
                {
                    con = new Vit();
                    so_Vit++;
                }
                else if (loai == 1)
                {
                    con = new Cuu();
                    so_Cuu++;
                }
                else
                {
                    con = new Bo();
                    so_Bo++;
                }
                danh_Sach_Gia_Suc.Add(con);
            }

            // Thống kê
            Console.WriteLine($"\nda sinh ra {so_Luong} con gia suc:");
            Console.WriteLine($"- {so_Vit} con vit");
            Console.WriteLine($"- {so_Cuu} con cuu");
            Console.WriteLine($"- {so_Bo} con bo\n");

            // Các tiếng kêu
            Console.WriteLine("tieng nghe duoc trong nong trai:");
            foreach (var con in danh_Sach_Gia_Suc)
            {
                Console.WriteLine(con.Keu_Len());
            }

            // Vắt sữa
            int tongSua = 0;
            foreach (var con in danh_Sach_Gia_Suc)
            {
                if (con is Bo bo)
                {
                    int sua = bo.Cho_Sua();
                    tongSua += sua;
                }
            }
            Console.WriteLine($"\ntong luong sua thu duoc: {tongSua} lit");

            // Sinh con non
            List<Gia_Suc> danh_Sach_Con_Non = new List<Gia_Suc>();
            foreach (var con in danh_Sach_Gia_Suc)
            {
                danh_Sach_Con_Non.AddRange(con.Sinh_Con(ngau_Nhien));
            }

            Console.WriteLine($"\nTong so con non duoc sinh ra : {danh_Sach_Con_Non.Count}");
            danh_Sach_Gia_Suc.AddRange(danh_Sach_Con_Non);
            Console.WriteLine($"\nTong so con non duoc sinh ra :  {danh_Sach_Con_Non.Count}");
        }
    }

}
