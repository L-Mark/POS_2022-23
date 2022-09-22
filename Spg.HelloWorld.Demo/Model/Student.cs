using System.ComponentModel.DataAnnotations;

namespace Spg.HelloWorld.Demo.Model {

    public class Student : EntityBase, IDisposable
    {
        private string name;
        
        /// <summary>
        /// Property! Set-/Get-Methode
        /// </summary>
        
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int myVar;
        
        public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("MyProperty darf nicht kleiner als 0 sein");
                }
                myVar = value;
            }
        }
        /// <summary>
        /// Zusammenfassung der Funktion (ein Satz)
        /// </summary>
        /// <remarks>
        /// Detaillierte Beschreibung der Methode
        /// </remarks>
        /// <see cref="Spg.HelloWorld.Demo.Model.EntityBase"/>
        /// <exception cref="NotImplementedException">Beschreibung der Exception, wann wird sie geworfen </exception>
        
        public void Dispose()
        {
            int myNumber = 5;
            throw new NotImplementedException();
        }
        
        public void save()
        {
            
        }
    }
    
}