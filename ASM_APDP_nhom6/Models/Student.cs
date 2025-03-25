namespace ASM_APDP_nhom6.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }  // Non-nullable property
        public string Password { get; set; }  // Non-nullable property

        // Constructor để gán giá trị cho các thuộc tính không nullable
        public Student(string name, string email, string password)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
