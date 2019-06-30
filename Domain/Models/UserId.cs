namespace students_task.Models{
    public class UserId{
        private int _id;
        public UserId(int id)
        {
            this._id = id;
        }
        public int Id
        {
            get => this._id;
            set => this._id = value;
        }
        static public implicit operator int (UserId id) => id.Id;
        static public implicit operator UserId(int id) => new UserId(id);
    }
}