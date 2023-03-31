namespace CSharpTest
{
    internal class AddressBook
    {
        private String name;
        private String phone;
        private String email;

        public String Name { get { return name; } }
        public String Phone
        {
            get
            {
                if (phone == null) return "未输入";
                return phone;
            }
            set
            { phone = value; }
        }
        public String Email
        {
            get
            {
                if (email == null) return "未输入";
                return email;
            }
            set { email = value; }
        }

        public AddressBook(String name, String phone, String email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        override public String ToString()
        {
            return String.Format("姓名：{0}\n电话：{1}\nEmail：{2}",
                Name,
                Phone,
                Email);
        }
    }
}
