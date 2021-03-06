using System.Data.Entity.ModelConfiguration;

namespace JinS.ExportOfTax.Data.Mapping
{
    public abstract class EfEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected EfEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}