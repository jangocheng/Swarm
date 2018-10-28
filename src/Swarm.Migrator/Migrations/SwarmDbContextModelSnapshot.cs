﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Swarm.Migrator;

namespace Swarm.Migrator.Migrations
{
    [DbContext(typeof(SwarmDbContext))]
    partial class SwarmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Swarm.Basic.Entity.Client", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NAME")
                        .HasMaxLength(120);

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnName("CONNECTION_ID")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("CreationTIme")
                        .HasColumnName("CREATION_TIME");

                    b.Property<string>("Group")
                        .HasColumnName("GROUP")
                        .HasMaxLength(120);

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnName("IP")
                        .HasMaxLength(50);

                    b.HasKey("Name");

                    b.HasIndex("Name", "Group")
                        .IsUnique()
                        .HasFilter("[GROUP] IS NOT NULL");

                    b.ToTable("SWARM_CLIENTS");
                });

            modelBuilder.Entity("Swarm.Basic.Entity.Job", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasMaxLength(32);

                    b.Property<bool>("ConcurrentExecutionDisallowed")
                        .HasColumnName("CONCURRENT_EXECUTION_DISALLOWED");

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION")
                        .HasMaxLength(500);

                    b.Property<int>("Executor")
                        .HasColumnName("EXECUTER");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnName("GROUP")
                        .HasMaxLength(120);

                    b.Property<DateTimeOffset?>("LastModificationTime")
                        .HasColumnName("LAST_MODIFICATION_TIME");

                    b.Property<int>("Load")
                        .HasColumnName("LOAD");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(120);

                    b.Property<string>("Owner")
                        .HasColumnName("OWNER")
                        .HasMaxLength(120);

                    b.Property<int>("Performer")
                        .HasColumnName("PERFORMER");

                    b.Property<int>("RetryCount")
                        .HasColumnName("RETRY_COUNT");

                    b.Property<int>("Sharding")
                        .HasColumnName("SHARDING");

                    b.Property<string>("ShardingParameters")
                        .HasColumnName("SHARDING_PARAMETERS")
                        .HasMaxLength(500);

                    b.Property<int>("State")
                        .HasColumnName("STATE");

                    b.Property<int>("Trigger")
                        .HasColumnName("TRIGGER");

                    b.HasKey("Id");

                    b.HasIndex("Group");

                    b.HasIndex("Name");

                    b.HasIndex("Owner");

                    b.ToTable("SWARM_JOBS");
                });

            modelBuilder.Entity("Swarm.Basic.Entity.JobProperty", b =>
                {
                    b.Property<string>("JobId")
                        .HasColumnName("JOB_ID")
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME");

                    b.Property<string>("Value")
                        .HasColumnName("VALUE")
                        .HasMaxLength(250);

                    b.HasKey("JobId", "Name");

                    b.HasIndex("JobId");

                    b.ToTable("SWARM_JOB_PROPERTIES");
                });

            modelBuilder.Entity("Swarm.Basic.Entity.JobState", b =>
                {
                    b.Property<string>("JobId")
                        .HasColumnName("JOB_ID")
                        .HasMaxLength(32);

                    b.Property<string>("TraceId")
                        .HasColumnName("TRACE_ID")
                        .HasMaxLength(32);

                    b.Property<string>("Client")
                        .HasColumnName("CLIENT")
                        .HasMaxLength(120);

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME");

                    b.Property<DateTimeOffset?>("LastModificationTime")
                        .HasColumnName("LAST_MODIFICATION_TIME");

                    b.Property<string>("Msg")
                        .HasColumnName("MSG")
                        .HasMaxLength(500);

                    b.Property<int>("State")
                        .HasColumnName("STATE");

                    b.HasKey("JobId", "TraceId", "Client");

                    b.HasIndex("JobId");

                    b.HasIndex("JobId", "TraceId");

                    b.HasIndex("TraceId", "Client")
                        .IsUnique();

                    b.ToTable("SWARM_JOB_STATE");
                });

            modelBuilder.Entity("Swarm.Basic.Entity.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME");

                    b.Property<string>("JobId")
                        .HasColumnName("JOB_ID")
                        .HasMaxLength(32);

                    b.Property<string>("Msg")
                        .HasColumnName("MSG");

                    b.Property<string>("TraceId")
                        .HasColumnName("TRACE_ID")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("SWARM_LOGS");
                });
#pragma warning restore 612, 618
        }
    }
}