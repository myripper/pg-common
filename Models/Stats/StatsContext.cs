using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PgCommon.Models.Stats;

namespace PgCommon.Context
{
    public partial class StatsContextRead : StatsContext
    {
        public StatsContextRead()
        {
        }

        public StatsContextRead(DbContextOptions<StatsContextRead> options)
            : base(options)
        {
        }
    }

    public partial class StatsContext : DbContext
    {
        public StatsContext()
        {
        }
        
        protected StatsContext(DbContextOptions options)
            : base(options)
        {
        }

        public StatsContext(DbContextOptions<StatsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StreamAggregatedTrade> StreamAggregatedTrade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StreamAggregatedTrade>(entity =>
            {
                entity.HasKey(e => e.AggregateTradeId)
                    .HasName("AggregateTradeId");

                entity.ToTable("stream_aggregated_trade");

                entity.Property(e => e.Event).HasMaxLength(10);

                entity.Property(e => e.EventTime).HasColumnType("timestampz");

                entity.Property(e => e.Price).HasColumnType("numeric(10,7)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(10,7)");

                entity.Property(e => e.Symbol).HasMaxLength(50);

                entity.Property(e => e.TradeTime).HasColumnType("timestampz");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
