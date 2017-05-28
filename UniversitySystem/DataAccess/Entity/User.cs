namespace DataAccess.Entity
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string PersonalId { get; set; }
        public string PictureId { get; set; }
        public int Birthday { get; set; }
        public int Birthmonth { get; set; }
        public int Birthyear { get; set; }
        


        
    
       public string ShowName() {
            string fullName = FirstName + " " + SecondName + " " + ThirdName;
            return fullName;
       
        }

       public string ShowBirthDay()
       {
           string Output = null;
           if (Birthday > 0 && Birthday <= 31 && Birthmonth>0 && Birthmonth<=12 && Birthyear > 1900 && Birthyear<=2016)
           {
           Output = Birthday.ToString() + "/" + Birthmonth.ToString() + "/" + Birthyear.ToString();
               
           }
           return Output;
       }
    }
}
