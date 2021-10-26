
namespace jon_crud.Service {

    public interface IScoped {
        
        string Id { get ; set ;  }

    }

    public class ScopedService : IScoped{
        public string Id { get ; set ;  }
        public ScopedService (){
            Id = System.Guid.NewGuid().ToString();
        }
    }

    


}