
namespace jon_crud.Service {

    public interface ISingleton {
        
        string Id { get ; set ;  }

    }

    public class SingletonService : ISingleton{
        public string Id { get ; set ;  }
        public SingletonService (){
            Id = System.Guid.NewGuid().ToString();
        }
    }

    


}