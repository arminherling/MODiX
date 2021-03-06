﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modix.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Modix.Data.Migrations
{
    [DbContext(typeof(ModixContext))]
    [Migration("20181230191851_Tags")]
    partial class Tags
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Modix.Data.Models.BehaviourConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BehaviourConfigurations");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ClaimMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Claim")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<long?>("RoleId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.ToTable("ClaimMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ConfigurationActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ClaimMappingId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long?>("DesignatedChannelMappingId");

                    b.Property<long?>("DesignatedRoleMappingId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClaimMappingId");

                    b.HasIndex("DesignatedChannelMappingId");

                    b.HasIndex("DesignatedRoleMappingId");

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("ConfigurationActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedChannelMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ChannelId");

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.ToTable("DesignatedChannelMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedRoleMappingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<long>("RoleId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("DesignatedRoleMappings");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildChannelEntity", b =>
                {
                    b.Property<long>("ChannelId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ChannelId");

                    b.ToTable("GuildChannels");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildRoleEntity", b =>
                {
                    b.Property<long>("RoleId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Position");

                    b.HasKey("RoleId");

                    b.ToTable("GuildRoles");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildUserEntity", b =>
                {
                    b.Property<long>("GuildId");

                    b.Property<long>("UserId");

                    b.Property<DateTimeOffset>("FirstSeen");

                    b.Property<DateTimeOffset>("LastSeen");

                    b.Property<string>("Nickname");

                    b.HasKey("GuildId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("GuildUsers");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.MessageEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("numeric(20)");

                    b.Property<decimal>("AuthorId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("numeric(20)");

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("numeric(20)");

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)))
                        .HasColumnType("numeric(20)");

                    b.Property<DateTimeOffset>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("GuildId", "AuthorId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.UserEntity", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.DeletedMessageEntity", b =>
                {
                    b.Property<long>("MessageId");

                    b.Property<long>("AuthorId");

                    b.Property<long>("ChannelId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("GuildId", "AuthorId");

                    b.ToTable("DeletedMessages");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.InfractionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<TimeSpan?>("Duration");

                    b.Property<long>("GuildId");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.Property<long?>("RescindActionId");

                    b.Property<long>("SubjectId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.HasIndex("RescindActionId")
                        .IsUnique();

                    b.HasIndex("GuildId", "SubjectId");

                    b.ToTable("Infractions");
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long?>("DeletedMessageId");

                    b.Property<long>("GuildId");

                    b.Property<long?>("InfractionId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DeletedMessageId");

                    b.HasIndex("InfractionId");

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("ModerationActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CampaignId");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long>("GuildId");

                    b.Property<long?>("NewCommentId");

                    b.Property<long?>("OldCommentId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("NewCommentId")
                        .IsUnique();

                    b.HasIndex("OldCommentId")
                        .IsUnique();

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("PromotionActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionCampaignEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CloseActionId");

                    b.Property<long>("CreateActionId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Outcome");

                    b.Property<long>("SubjectId");

                    b.Property<long>("TargetRoleId");

                    b.HasKey("Id");

                    b.HasIndex("CloseActionId")
                        .IsUnique();

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("TargetRoleId");

                    b.HasIndex("GuildId", "SubjectId");

                    b.ToTable("PromotionCampaigns");
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionCommentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CampaignId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("ModifyActionId");

                    b.Property<string>("Sentiment")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("ModifyActionId")
                        .IsUnique();

                    b.ToTable("PromotionComments");
                });

            modelBuilder.Entity("Modix.Data.Models.Tags.TagActionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<long>("CreatedById");

                    b.Property<long>("GuildId");

                    b.Property<long?>("NewTagId");

                    b.Property<long?>("OldTagId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("NewTagId")
                        .IsUnique();

                    b.HasIndex("OldTagId")
                        .IsUnique();

                    b.HasIndex("GuildId", "CreatedById");

                    b.ToTable("TagActions");
                });

            modelBuilder.Entity("Modix.Data.Models.Tags.TagEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<long>("CreateActionId");

                    b.Property<long?>("DeleteActionId");

                    b.Property<long>("GuildId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("Uses");

                    b.HasKey("Id");

                    b.HasIndex("CreateActionId")
                        .IsUnique();

                    b.HasIndex("DeleteActionId")
                        .IsUnique();

                    b.HasIndex("GuildId");

                    b.HasIndex("Name");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ClaimMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.ClaimMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.ClaimMappingEntity", "DeleteActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.ConfigurationActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ClaimMappingEntity", "ClaimMapping")
                        .WithMany()
                        .HasForeignKey("ClaimMappingId");

                    b.HasOne("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "DesignatedChannelMapping")
                        .WithMany()
                        .HasForeignKey("DesignatedChannelMappingId");

                    b.HasOne("Modix.Data.Models.Core.DesignatedRoleMappingEntity", "DesignatedRoleMapping")
                        .WithMany()
                        .HasForeignKey("DesignatedRoleMappingId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedChannelMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.GuildChannelEntity", "Channel")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedChannelMappingEntity", "DeleteActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Core.DesignatedRoleMappingEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedRoleMappingEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.ConfigurationActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Core.DesignatedRoleMappingEntity", "DeleteActionId");

                    b.HasOne("Modix.Data.Models.Core.GuildRoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Core.GuildUserEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.DeletedMessageEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Core.GuildChannelEntity", "Channel")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.DeletedMessageEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "Author")
                        .WithMany()
                        .HasForeignKey("GuildId", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.InfractionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "DeleteActionId");

                    b.HasOne("Modix.Data.Models.Moderation.ModerationActionEntity", "RescindAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Moderation.InfractionEntity", "RescindActionId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "Subject")
                        .WithMany()
                        .HasForeignKey("GuildId", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Moderation.ModerationActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Moderation.DeletedMessageEntity", "DeletedMessage")
                        .WithMany()
                        .HasForeignKey("DeletedMessageId");

                    b.HasOne("Modix.Data.Models.Moderation.InfractionEntity", "Infraction")
                        .WithMany()
                        .HasForeignKey("InfractionId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Promotions.PromotionCampaignEntity", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId");

                    b.HasOne("Modix.Data.Models.Promotions.PromotionCommentEntity", "NewComment")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionActionEntity", "NewCommentId");

                    b.HasOne("Modix.Data.Models.Promotions.PromotionCommentEntity", "OldComment")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionActionEntity", "OldCommentId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionCampaignEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Promotions.PromotionActionEntity", "CloseAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionCampaignEntity", "CloseActionId");

                    b.HasOne("Modix.Data.Models.Promotions.PromotionActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionCampaignEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.GuildRoleEntity", "TargetRole")
                        .WithMany()
                        .HasForeignKey("TargetRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "Subject")
                        .WithMany()
                        .HasForeignKey("GuildId", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Promotions.PromotionCommentEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Promotions.PromotionCampaignEntity", "Campaign")
                        .WithMany("Comments")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Promotions.PromotionActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionCommentEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Promotions.PromotionActionEntity", "ModifyAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Promotions.PromotionCommentEntity", "ModifyActionId");
                });

            modelBuilder.Entity("Modix.Data.Models.Tags.TagActionEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Tags.TagEntity", "NewTag")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Tags.TagActionEntity", "NewTagId");

                    b.HasOne("Modix.Data.Models.Tags.TagEntity", "OldTag")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Tags.TagActionEntity", "OldTagId");

                    b.HasOne("Modix.Data.Models.Core.GuildUserEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("GuildId", "CreatedById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Modix.Data.Models.Tags.TagEntity", b =>
                {
                    b.HasOne("Modix.Data.Models.Tags.TagActionEntity", "CreateAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Tags.TagEntity", "CreateActionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Modix.Data.Models.Tags.TagActionEntity", "DeleteAction")
                        .WithOne()
                        .HasForeignKey("Modix.Data.Models.Tags.TagEntity", "DeleteActionId");
                });
#pragma warning restore 612, 618
        }
    }
}
