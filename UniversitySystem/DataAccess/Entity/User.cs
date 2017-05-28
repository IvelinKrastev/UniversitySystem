namespace DataAccess.Entity
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string PersonalId { get; set; }
        public string PictureId { get; set; }


        
    
       public string ShowName() {
            string fullName = FirstName + " " + SecondName + " " + ThirdName;
            return fullName;
       
        }
    }
}
