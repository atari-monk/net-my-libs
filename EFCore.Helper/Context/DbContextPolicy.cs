using Microsoft.EntityFrameworkCore;

namespace EFCore.Helper;

public abstract class DbContextPolicy
    : DbContextTemplate
{
  public DbContextPolicy()
      : base()
  {

  }

  public DbContextPolicy(DbContextOptions<DbContextPolicy> options)
      : base(options)
  {
  }

  protected DbContextPolicy(DbContextOptions options)
      : base(options)
  {
  }

  protected override void SetPolicy(ModelBuilder builder)
  {
    SetRestrictDeleteBehaviorPolicy(builder);
  }

  private static void SetRestrictDeleteBehaviorPolicy(ModelBuilder builder)
  {
    var cascadeFKs = builder.Model.GetEntityTypes()
        .SelectMany(t => t.GetForeignKeys())
        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

    foreach (var fk in cascadeFKs)
      fk.DeleteBehavior = DeleteBehavior.Restrict;
  }
}