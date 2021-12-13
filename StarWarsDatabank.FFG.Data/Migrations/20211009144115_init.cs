using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsDatabank.FFG.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Items");

            migrationBuilder.EnsureSchema(
                name: "Books");

            migrationBuilder.EnsureSchema(
                name: "Skills");

            migrationBuilder.EnsureSchema(
                name: "Talent");

            migrationBuilder.CreateTable(
                name: "ArmorCategories",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCategories", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "ArmorQualities",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorQualities", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "CombatSkills",
                schema: "Skills",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombatSkills", x => x.AggregateId);
                });

            migrationBuilder.CreateTable(
                name: "GamerVersions",
                schema: "Books",
                columns: table => new
                {
                    GameVersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamerVersions", x => x.GameVersionId);
                });

            migrationBuilder.CreateTable(
                name: "GearCategories",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearCategories", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSkills",
                schema: "Skills",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSkills", x => x.AggregateId);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeSkills",
                schema: "Skills",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Characteristic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeSkills", x => x.AggregateId);
                });

            migrationBuilder.CreateTable(
                name: "ModTypes",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModTypes", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "TalentActivations",
                schema: "Talent",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentActivations", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponCategories",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCategories", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponQualities",
                schema: "Items",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponQualities", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Armor",
                schema: "Items",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryEntityId = table.Column<int>(type: "int", nullable: true),
                    Soak = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Encumberance = table.Column<int>(type: "int", nullable: false),
                    HardPoints = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Speical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.AggregateId);
                    table.ForeignKey(
                        name: "FK_Armor_ArmorCategories_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalSchema: "Items",
                        principalTable: "ArmorCategories",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmorCategories_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    ArmorCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCategories_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_ArmorCategories_Books_ArmorCategories_ArmorCategoryId",
                        column: x => x.ArmorCategoryId,
                        principalSchema: "Items",
                        principalTable: "ArmorCategories",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorQualities_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    ArmorQualityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorQualities_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_ArmorQualities_Books_ArmorQualities_ArmorQualityId",
                        column: x => x.ArmorQualityId,
                        principalSchema: "Items",
                        principalTable: "ArmorQualities",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombatSkills_Books",
                schema: "Skills",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    CombatSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombatSkills_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_CombatSkills_Books_CombatSkills_CombatSkillId",
                        column: x => x.CombatSkillId,
                        principalSchema: "Skills",
                        principalTable: "CombatSkills",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                schema: "Items",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CombatSkillId = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    AddAbilityScoreToDamage = table.Column<bool>(type: "bit", nullable: false),
                    Critical = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Encumberance = table.Column<double>(type: "float", nullable: false),
                    HardPoints = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Restricted = table.Column<bool>(type: "bit", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.AggregateId);
                    table.ForeignKey(
                        name: "FK_Weapons_CombatSkills_CombatSkillId",
                        column: x => x.CombatSkillId,
                        principalSchema: "Skills",
                        principalTable: "CombatSkills",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameVersionId = table.Column<int>(type: "int", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_GamerVersions_GameVersionId",
                        column: x => x.GameVersionId,
                        principalSchema: "Books",
                        principalTable: "GamerVersions",
                        principalColumn: "GameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gear",
                schema: "Items",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryEntityId = table.Column<int>(type: "int", nullable: true),
                    Encumberance = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Special = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gear", x => x.AggregateId);
                    table.ForeignKey(
                        name: "FK_Gear_GearCategories_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalSchema: "Items",
                        principalTable: "GearCategories",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GearCategories_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    GearCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearCategories_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_GearCategories_Books_GearCategories_GearCategoryId",
                        column: x => x.GearCategoryId,
                        principalSchema: "Items",
                        principalTable: "GearCategories",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralSkills_Books",
                schema: "Skills",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    GeneralSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSkills_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_GeneralSkills_Books_GeneralSkills_GeneralSkillId",
                        column: x => x.GeneralSkillId,
                        principalSchema: "Skills",
                        principalTable: "GeneralSkills",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeSkills_Books",
                schema: "Skills",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    KnowledgeSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeSkills_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_KnowledgeSkills_Books_KnowledgeSkills_KnowledgeSkillId",
                        column: x => x.KnowledgeSkillId,
                        principalSchema: "Skills",
                        principalTable: "KnowledgeSkills",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mods",
                schema: "Items",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeEntityId = table.Column<int>(type: "int", nullable: true),
                    HardPoints = table.Column<int>(type: "int", nullable: false),
                    Encumberance = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IsRestricted = table.Column<bool>(type: "bit", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    BaseModifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FurtherMods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mods", x => x.AggregateId);
                    table.ForeignKey(
                        name: "FK_Mods_ModTypes_TypeEntityId",
                        column: x => x.TypeEntityId,
                        principalSchema: "Items",
                        principalTable: "ModTypes",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModTypes_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    ModTypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModTypes_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_ModTypes_Books_ModTypes_ModTypesId",
                        column: x => x.ModTypesId,
                        principalSchema: "Items",
                        principalTable: "ModTypes",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentActivations_Books",
                schema: "Talent",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    TalentActivationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentActivations_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_TalentActivations_Books_TalentActivations_TalentActivationId",
                        column: x => x.TalentActivationId,
                        principalSchema: "Talent",
                        principalTable: "TalentActivations",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                schema: "Talent",
                columns: table => new
                {
                    AggregateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivationEntityId = table.Column<int>(type: "int", nullable: true),
                    Ranked = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.AggregateId);
                    table.ForeignKey(
                        name: "FK_Talents_TalentActivations_ActivationEntityId",
                        column: x => x.ActivationEntityId,
                        principalSchema: "Talent",
                        principalTable: "TalentActivations",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeaponCategories_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    WeaponCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCategories_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_WeaponCategories_Books_WeaponCategories_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalSchema: "Items",
                        principalTable: "WeaponCategories",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponQualities_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    WeaponQualityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponQualities_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_WeaponQualities_Books_WeaponQualities_WeaponQualityId",
                        column: x => x.WeaponQualityId,
                        principalSchema: "Items",
                        principalTable: "WeaponQualities",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Armor_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    ArmorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Armor_Books_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalSchema: "Items",
                        principalTable: "Armor",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorArmorQualities",
                schema: "Items",
                columns: table => new
                {
                    ArmorsAggregateId = table.Column<int>(type: "int", nullable: false),
                    QualitiesEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorArmorQualities", x => new { x.ArmorsAggregateId, x.QualitiesEntityId });
                    table.ForeignKey(
                        name: "FK_ArmorArmorQualities_Armor_ArmorsAggregateId",
                        column: x => x.ArmorsAggregateId,
                        principalSchema: "Items",
                        principalTable: "Armor",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorArmorQualities_ArmorQualities_QualitiesEntityId",
                        column: x => x.QualitiesEntityId,
                        principalSchema: "Items",
                        principalTable: "ArmorQualities",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Weapons_Books_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalSchema: "Items",
                        principalTable: "Weapons",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponWeaponQuality",
                schema: "Items",
                columns: table => new
                {
                    QualitiesEntityId = table.Column<int>(type: "int", nullable: false),
                    WeaponsAggregateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponWeaponQuality", x => new { x.QualitiesEntityId, x.WeaponsAggregateId });
                    table.ForeignKey(
                        name: "FK_WeaponWeaponQuality_WeaponQualities_QualitiesEntityId",
                        column: x => x.QualitiesEntityId,
                        principalSchema: "Items",
                        principalTable: "WeaponQualities",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponQuality_Weapons_WeaponsAggregateId",
                        column: x => x.WeaponsAggregateId,
                        principalSchema: "Items",
                        principalTable: "Weapons",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gear_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    GearId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gear_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Gear_Books_Gear_GearId",
                        column: x => x.GearId,
                        principalSchema: "Items",
                        principalTable: "Gear",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mods_Books",
                schema: "Items",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    ModId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mods_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Mods_Books_Mods_ModId",
                        column: x => x.ModId,
                        principalSchema: "Items",
                        principalTable: "Mods",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talents_Books",
                schema: "Talent",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    TalentActivationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Talents_Books_Talents_TalentActivationId",
                        column: x => x.TalentActivationId,
                        principalSchema: "Talent",
                        principalTable: "Talents",
                        principalColumn: "AggregateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armor_CategoryEntityId",
                schema: "Items",
                table: "Armor",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Armor_Books_ArmorId",
                schema: "Items",
                table: "Armor_Books",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorArmorQualities_QualitiesEntityId",
                schema: "Items",
                table: "ArmorArmorQualities",
                column: "QualitiesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCategories_Books_ArmorCategoryId",
                schema: "Items",
                table: "ArmorCategories_Books",
                column: "ArmorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorQualities_Books_ArmorQualityId",
                schema: "Items",
                table: "ArmorQualities_Books",
                column: "ArmorQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GameVersionId",
                schema: "Books",
                table: "Books",
                column: "GameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_CombatSkills_Books_CombatSkillId",
                schema: "Skills",
                table: "CombatSkills_Books",
                column: "CombatSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Gear_CategoryEntityId",
                schema: "Items",
                table: "Gear",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Gear_Books_GearId",
                schema: "Items",
                table: "Gear_Books",
                column: "GearId");

            migrationBuilder.CreateIndex(
                name: "IX_GearCategories_Books_GearCategoryId",
                schema: "Items",
                table: "GearCategories_Books",
                column: "GearCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSkills_Books_GeneralSkillId",
                schema: "Skills",
                table: "GeneralSkills_Books",
                column: "GeneralSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgeSkills_Books_KnowledgeSkillId",
                schema: "Skills",
                table: "KnowledgeSkills_Books",
                column: "KnowledgeSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Mods_TypeEntityId",
                schema: "Items",
                table: "Mods",
                column: "TypeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Mods_Books_ModId",
                schema: "Items",
                table: "Mods_Books",
                column: "ModId");

            migrationBuilder.CreateIndex(
                name: "IX_ModTypes_Books_ModTypesId",
                schema: "Items",
                table: "ModTypes_Books",
                column: "ModTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentActivations_Books_TalentActivationId",
                schema: "Talent",
                table: "TalentActivations_Books",
                column: "TalentActivationId");

            migrationBuilder.CreateIndex(
                name: "IX_Talents_ActivationEntityId",
                schema: "Talent",
                table: "Talents",
                column: "ActivationEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Talents_Books_TalentActivationId",
                schema: "Talent",
                table: "Talents_Books",
                column: "TalentActivationId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCategories_Books_WeaponCategoryId",
                schema: "Items",
                table: "WeaponCategories_Books",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponQualities_Books_WeaponQualityId",
                schema: "Items",
                table: "WeaponQualities_Books",
                column: "WeaponQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CombatSkillId",
                schema: "Items",
                table: "Weapons",
                column: "CombatSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_Books_WeaponId",
                schema: "Items",
                table: "Weapons_Books",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponQuality_WeaponsAggregateId",
                schema: "Items",
                table: "WeaponWeaponQuality",
                column: "WeaponsAggregateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ArmorArmorQualities",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ArmorCategories_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ArmorQualities_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "Books");

            migrationBuilder.DropTable(
                name: "CombatSkills_Books",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "Gear_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "GearCategories_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "GeneralSkills_Books",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "KnowledgeSkills_Books",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "Mods_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ModTypes_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "TalentActivations_Books",
                schema: "Talent");

            migrationBuilder.DropTable(
                name: "Talents_Books",
                schema: "Talent");

            migrationBuilder.DropTable(
                name: "WeaponCategories_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "WeaponQualities_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "Weapons_Books",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "WeaponWeaponQuality",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "Armor",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ArmorQualities",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "GamerVersions",
                schema: "Books");

            migrationBuilder.DropTable(
                name: "Gear",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "GeneralSkills",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "KnowledgeSkills",
                schema: "Skills");

            migrationBuilder.DropTable(
                name: "Mods",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "Talents",
                schema: "Talent");

            migrationBuilder.DropTable(
                name: "WeaponCategories",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "WeaponQualities",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "Weapons",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ArmorCategories",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "GearCategories",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "ModTypes",
                schema: "Items");

            migrationBuilder.DropTable(
                name: "TalentActivations",
                schema: "Talent");

            migrationBuilder.DropTable(
                name: "CombatSkills",
                schema: "Skills");
        }
    }
}
