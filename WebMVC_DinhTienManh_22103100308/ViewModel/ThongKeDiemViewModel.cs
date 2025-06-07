using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Drawing.Printing;
using System.Security.Cryptography.Pkcs;
using WebMVC_DinhTienManh_22103100308.Models;

namespace WebMVC_DinhTienManh_22103100308.ViewModel
{
    public class ThongKeDiemViewModel
    {
        public int StudentId {  get; set; }
        public string FullName {  get; set; }
        public DateTime BrithDate { get; set; } 
        public float AverageScore { get; set; }
        public List<Result> ListDiem { get; set; }
    }
}
