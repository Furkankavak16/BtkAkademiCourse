namespace BtkAkademi
{
    public struct Student
    {

        

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Departmant { get; set; }
        public string City { get; set; }


        public override string ToString()
        {
            return $"{Id,2} {FirstName,10} {LastName,10} " +
                $"{Gender,10} {Departmant,15} {City,10} ";

        }
    }

}
