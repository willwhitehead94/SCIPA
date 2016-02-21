namespace SCIPA.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<AlarmType> AlarmTypes { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<CommandType> CommandTypes { get; set; }
        public virtual DbSet<Communicator> Communicators { get; set; }
        public virtual DbSet<CommunicatorType> CommunicatorTypes { get; set; }
        public virtual DbSet<DatabaseCommunicator> DatabaseCommunicators { get; set; }
        public virtual DbSet<DatabaseType> DatabaseTypes { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceValue> DeviceValues { get; set; }
        public virtual DbSet<FileCommunicator> FileCommunicators { get; set; }
        public virtual DbSet<FileOpenMode> FileOpenModes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<SerialCommunicator> SerialCommunicators { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ValueType> ValueTypes { get; set; }
        public virtual DbSet<ApplicationInformation> ApplicationInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alarm>()
                .Property(e => e.value)
                .IsFixedLength();

            modelBuilder.Entity<AlarmType>()
                .Property(e => e.alarmType1)
                .IsFixedLength();

            modelBuilder.Entity<AlarmType>()
                .HasMany(e => e.Alarms)
                .WithRequired(e => e.AlarmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Command>()
                .Property(e => e.commandText)
                .IsFixedLength();

            modelBuilder.Entity<Command>()
                .HasMany(e => e.Rules)
                .WithMany(e => e.Commands)
                .Map(m => m.ToTable("RuleCommandLookup").MapLeftKey("commandId").MapRightKey("ruleId"));

            modelBuilder.Entity<CommandType>()
                .Property(e => e.commandType1)
                .IsFixedLength();

            modelBuilder.Entity<CommandType>()
                .HasMany(e => e.Commands)
                .WithRequired(e => e.CommandType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommunicatorType>()
                .Property(e => e.communicatorType1)
                .IsFixedLength();

            modelBuilder.Entity<CommunicatorType>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.CommunicatorType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatabaseCommunicator>()
                .Property(e => e.connectionString)
                .IsFixedLength();

            modelBuilder.Entity<DatabaseCommunicator>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.DatabaseCommunicator)
                .HasForeignKey(e => e.subId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatabaseType>()
                .Property(e => e.databaseType1)
                .IsFixedLength();

            modelBuilder.Entity<DatabaseType>()
                .HasMany(e => e.DatabaseCommunicators)
                .WithRequired(e => e.DatabaseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Device>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Device>()
                .Property(e => e.custodian)
                .IsUnicode(false);

            modelBuilder.Entity<Device>()
                .HasOptional(e => e.Alarm)
                .WithRequired(e => e.Device);

            modelBuilder.Entity<Device>()
                .HasOptional(e => e.Command)
                .WithRequired(e => e.Device);

            /*modelBuilder.Entity<Device>()
                .HasOptional(e => e.Command1)
                .WithRequired(e => e.Device1);*/

            modelBuilder.Entity<Device>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Device>()
                .HasMany(e => e.DeviceValues)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Device>()
                .HasMany(e => e.Rules)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceValue>()
                .Property(e => e.value)
                .IsFixedLength();

            modelBuilder.Entity<FileCommunicator>()
                .Property(e => e.filePath)
                .IsUnicode(false);

            modelBuilder.Entity<FileCommunicator>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.FileCommunicator)
                .HasForeignKey(e => e.subId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileOpenMode>()
                .Property(e => e.openMode)
                .IsFixedLength();

            modelBuilder.Entity<FileOpenMode>()
                .HasMany(e => e.FileCommunicators)
                .WithRequired(e => e.FileOpenMode)
                .HasForeignKey(e => e.openModeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Location>()
                .Property(e => e.notes)
                .IsFixedLength();

            modelBuilder.Entity<Rule>()
                .Property(e => e.ruleText)
                .IsFixedLength();

            modelBuilder.Entity<SerialCommunicator>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.SerialCommunicator)
                .HasForeignKey(e => e.subId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValueType>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<ValueType>()
                .HasMany(e => e.Commands)
                .WithRequired(e => e.ValueType)
                .HasForeignKey(e => e.returnValueTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValueType>()
                .HasMany(e => e.Communicators)
                .WithRequired(e => e.ValueType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationInformation>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);
        }
    }
}
