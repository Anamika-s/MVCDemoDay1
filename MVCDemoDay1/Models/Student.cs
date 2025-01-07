namespace MVCDemoDay1.Models
{
    public class Student
    {
        public int Rn { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public int Marks { get; set; }
    }
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public static class GlobalData
    {
        public static bool isLoggedIn { get; set; }
    }
}
