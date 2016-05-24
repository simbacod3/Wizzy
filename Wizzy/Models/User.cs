using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizzy.Models
{
    class User
    {
        #region ATTRIBUTES

        private string lastName { get; set; }
        private string firstName { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private object socialMedia { get; set; }
        private string pathBodypic { get; set; }
        private string pathPicture { get; set; }
        private string shirtSize { get; set; }
        private bool gender { get; set; }
        private int age { get; set; }
        private int id { get; set; }
        private int pentSize { get; set; }
        private int shoeSize { get; set; }
        private double height { get; set; }
        private double weight { get; set; }
        private List<Category> clothesCategory { get; set; }
        private List<Dressing> dressingList { get; set; }

        #endregion

        #region CONSTRUCTORS
        public User()
        {

        }

        /// <summary>
        /// Basic constructor to call at the connection of the user,
        /// When the user is already registred inside the Device ( XML or JSON file ).
        /// Will create a new instance of the user (that already exist in fact)
        /// 
        /// </summary>
        /// <param name="LastName">Explicit STRING</param>
        /// <param name="FirstName">Explicit STRING</param>
        /// <param name="Email">Explicit STRING</param>
        /// <param name="Password">Explicit STRING</param>
        /// <param name="SocialMedia">Explicit OBJECT</param>
        /// <param name="PathBodypic">Explicit STRING</param>
        /// <param name="PathPicture">Explicit STRING</param>
        /// <param name="ShirtSize">Explicit STRING</param>
        /// <param name="Gender">Explicit BOOL</param>
        /// <param name="Age">Explicit INT</param>
        /// <param name="Id">Explicit INT</param>
        /// <param name="PentSize">Explicit INT</param>
        /// <param name="ShoeSize">Explicit INT</param>
        /// <param name="Height">Explicit INT</param>
        /// <param name="Weight">Explicit INT</param>
        /// <param name="ClothesCategory">Explicit LIST-CATEGORY</param>
        /// <param name="DressingList">Explicit LIST-DRESSING</param>
        public User(string LastName, string FirstName, string Email, string Password, object SocialMedia, string PathBodypic,
                    string PathPicture, string ShirtSize, bool Gender, int Age, int Id, int PentSize, int ShoeSize, double Height,
                    double Weight, List<Category> ClothesCategory, List<Dressing> DressingList)
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.email = Email;
            this.password = Password;
            this.socialMedia = SocialMedia;
            this.pathBodypic = PathBodypic;
            this.pathPicture = PathPicture;
            this.shirtSize = ShirtSize;
            this.gender = Gender;
            this.age = Age;
            this.id = Id;
            this.pentSize = PentSize;
            this.shoeSize = ShoeSize;
            this.height = Height;
            this.weight = Weight;
            this.clothesCategory = ClothesCategory;
            this.dressingList = DressingList;
        }


        /// <summary>
        /// If User Already exists USE THIS CONSTRUCTOR
        /// Both list created will be set to null as new list 
        /// The object will also be sent to a value passed ( Basics categories )
        ///
        /// </summary>
        /// <param name="LastName">Explicit STRING</param>
        /// <param name="FirstName">Explicit STRING</param>
        /// <param name="Email">Explicit STRING</param>
        /// <param name="Password">Explicit STRING</param>
        /// <param name="SocialMedia">Explicit OBJECT</param>
        /// <param name="PathBodypic">Explicit STRING</param>
        /// <param name="PathPicture">Explicit STRING</param>
        /// <param name="ShirtSize">Explicit STRING</param>
        /// <param name="Gender">Explicit BOOL</param>
        /// <param name="Age">Explicit INT</param>
        /// <param name="Id">Explicit INT</param>
        /// <param name="PentSize">Explicit INT</param>
        /// <param name="ShoeSize">Explicit INT</param>
        /// <param name="Height">Explicit INT</param>
        /// <param name="Weight">Explicit INT</param>
        public User(string LastName, string FirstName, string Email, string Password, object SocialMedia, string PathBodypic,
                    string PathPicture, string ShirtSize, bool Gender, int Age, int Id, int PentSize, int ShoeSize, double Height,
                    double Weight)
        {
            this.lastName = LastName;
            this.firstName = FirstName;
            this.email = Email;
            this.password = Password;
            this.socialMedia = SocialMedia;
            this.pathBodypic = PathBodypic;
            this.pathPicture = PathPicture;
            this.shirtSize = ShirtSize;
            this.gender = Gender;
            this.age = Age;
            this.id = Id;
            this.pentSize = PentSize;
            this.shoeSize = ShoeSize;
            this.height = Height;
            this.weight = Weight;

            /// To initialize both list if we want to create new user.

            this.clothesCategory = new List<Category>();
            this.dressingList = new List<Dressing>();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return "Vous êtes :" + " "+ this.firstName + " "+ this.lastName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifer"></param>
        /// <param name="elementToModify"></param>
        /// <returns></returns>
        public string Modify(string identifer, string elementToModify)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dressingToAdd"></param>
        /// <returns></returns>
        public bool Add_Dressing(Dressing dressingToAdd)
        {
            try
            {
                this.dressingList.Add(dressingToAdd);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dressingToDelete"></param>
        /// <returns></returns>
        public bool Delete_Dressing(Dressing dressingToDelete)
        {
            try
            {
                this.dressingList.Remove(dressingToDelete);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dressingToModify"></param>
        /// <returns></returns>
        public Dressing Modify_Dressing(Dressing dressingToModify)
        {
            try
            {
                
                return new Dressing();
            }
            catch(Exception ex)
            {
                return new Dressing();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryToAdd"></param>
        /// <returns></returns>
        public bool Add_Category(Category categoryToAdd)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryToDelete"></param>
        /// <returns></returns>
        public bool Delete_Category(Category categoryToDelete)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryToModify"></param>
        /// <returns></returns>
        public Category Modify_Category(Category categoryToModify)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="socialMedia"></param>
        /// <returns></returns>
        public bool Add_SocialMedia(string socialMedia)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="socialMedia"></param>
        /// <returns></returns>
        public bool Delete_SocialMedia(string socialMedia)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="socialMedia"></param>
        /// <returns></returns>
        public object Modify_SocialMedia(string socialMedia)
        {

        }

        #endregion
    }
}
