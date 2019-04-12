
namespace BenChainClient.Api.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {
    public UnitOfWork()
    {
      ParticipantRepository = new ParticipantRepository();
    }

    //Interface
    public ParticipantRepository ParticipantRepository { get; set; }
  }
}
