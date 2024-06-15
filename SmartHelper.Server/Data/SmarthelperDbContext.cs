using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartHelper.Server.Models.Auth;
using SmartHelper.Server.Models.PremisesAndFacilities;
using SmartHelper.Server.Models.SupportMeasures;
using SmartHelper.Server.Models.TechnoparkAndSez;

namespace SmartHelper.Server.Data;

public partial class SmarthelperDbContext : DbContext
{
    public SmarthelperDbContext()
    {
    }

    public SmarthelperDbContext(DbContextOptions<SmarthelperDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthRequestHistory> AuthRequestHistories { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<SAdditionalSiteCharacteristic> SAdditionalSiteCharacteristics { get; set; }

    public virtual DbSet<SGasSupply> SGasSupplies { get; set; }

    public virtual DbSet<SHeatSupply> SHeatSupplies { get; set; }

    public virtual DbSet<SPowerSupply> SPowerSupplies { get; set; }

    public virtual DbSet<SSiteCharacteristic> SSiteCharacteristics { get; set; }

    public virtual DbSet<SWaterDisposal> SWaterDisposals { get; set; }

    public virtual DbSet<SWaterSupply> SWaterSupplies { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SpNpa> SpNpas { get; set; }

    public virtual DbSet<SpSubmissionOfDocument> SpSubmissionOfDocuments { get; set; }

    public virtual DbSet<SpSupportMeasure> SpSupportMeasures { get; set; }

    public virtual DbSet<TasAdministrativeCenter> TasAdministrativeCenters { get; set; }

    public virtual DbSet<TasDescriptionObject> TasDescriptionObjects { get; set; }

    public virtual DbSet<TasFinance> TasFinances { get; set; }

    public virtual DbSet<TasLocationObject> TasLocationObjects { get; set; }

    public virtual DbSet<TasTechnoparksAndSez> TasTechnoparksAndSezs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=smarthelper_db;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthRequestHistory>(entity =>
        {
            entity.HasKey(e => e.ResponseId).HasName("auth_request_history_pkey");

            entity.ToTable("auth_request_history");

            entity.HasIndex(e => e.UserId, "auth_request_history_user_id_key").IsUnique();

            entity.Property(e => e.ResponseId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("response_id");
            entity.Property(e => e.DataRequest).HasColumnName("data_request");
            entity.Property(e => e.Request)
                .HasColumnType("character varying")
                .HasColumnName("request");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.UserId).HasColumnName("user_id");

        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("auth_users_pkey");

            entity.ToTable("auth_users");

            entity.HasIndex(e => e.Email, "auth_users_email_key").IsUnique();

            entity.HasIndex(e => e.Inn, "auth_users_inn_key").IsUnique();

            entity.Property(e => e.UserId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("user_id");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.Inn)
                .HasColumnType("character varying")
                .HasColumnName("inn");
            entity.Property(e => e.LastName)
                .HasColumnType("character varying")
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasColumnType("character varying")
                .HasColumnName("middle_name");
            entity.Property(e => e.NameOfOrganization)
                .HasColumnType("character varying")
                .HasColumnName("name_of_organization");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.Post)
                .HasColumnType("character varying")
                .HasColumnName("post");
            entity.Property(e => e.Role)
                .HasColumnType("character varying")
                .HasColumnName("role");
            entity.Property(e => e.TypeOfIndustry)
                .HasColumnType("character varying")
                .HasColumnName("type_of_industry");
            entity.Property(e => e.WebsiteOrganization)
                .HasColumnType("character varying")
                .HasColumnName("website_organization");

            entity.HasOne(d => d.AuthRequestHistory).WithOne(p => p.User)
                .HasForeignKey<AuthRequestHistory>(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("auth_request_history_user_id_fkey");
        });

        modelBuilder.Entity<SAdditionalSiteCharacteristic>(entity =>
        {
            entity
                .HasKey(e => e.Id).HasName("SAdditionalSiteCharacteristicId");

            entity.ToTable("s_additional_site_characteristics");

            entity.Property(e => e.AvailabilityAccessRoads)
                .HasColumnType("character varying")
                .HasColumnName("availability_access_roads");
            entity.Property(e => e.AvailabilityMaip)
                .HasColumnType("character varying")
                .HasColumnName("availability_maip");
            entity.Property(e => e.DescriptionApplicationProcedure).HasColumnName("description_application_procedure");
            entity.Property(e => e.DescriptionBenefits).HasColumnName("description_benefits");
            entity.Property(e => e.ExportTkoAvailability)
                .HasColumnType("character varying")
                .HasColumnName("export_tko_availability");
            entity.Property(e => e.ExportTkoTariffRubCub).HasColumnName("export_tko_tariff_rub_cub");
            entity.Property(e => e.ExportTkoTariffRubTon)
                .HasColumnType("character varying")
                .HasColumnName("export_tko_tariff_rub_ton");
            entity.Property(e => e.LinkApplicationForm)
                .HasColumnType("character varying")
                .HasColumnName("link_application_form");
            entity.Property(e => e.ListDocumentsRequiredSubmitApplication).HasColumnName("list_documents_required_submit_application");
            entity.Property(e => e.ListTypesEconomicActivities).HasColumnName("list_types_economic_activities");
            entity.Property(e => e.OtherCharacteristics).HasColumnName("other_characteristics");
            entity.Property(e => e.OtherInformation).HasColumnName("other_information");
            entity.Property(e => e.ParkingForTruks)
                .HasColumnType("character varying")
                .HasColumnName("parking_for_truks");
            entity.Property(e => e.PhotosObject)
                .HasColumnType("character varying")
                .HasColumnName("photos_object");
            entity.Property(e => e.RailwayAvailability)
                .HasColumnType("character varying")
                .HasColumnName("railway_availability");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.UrbanCharacteristicsAndLimitations).HasColumnName("urban_characteristics_and_limitations");
            entity.Property(e => e.UrbanPlanningDocument).HasColumnName("urban_planning_document");
                        
        });

        modelBuilder.Entity<SGasSupply>(entity =>
        {
            entity.HasKey(e => e.GasSupplyId).HasName("s_gas_supply_pkey");
            entity.ToTable("s_gas_supply");
            entity.Property(e => e.GasSupplyId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("gas_supply_id");

            entity.Property(e => e.SiteId).HasColumnName("site_id");
        });

        modelBuilder.Entity<SHeatSupply>(entity =>
        {
            entity.HasKey(e => e.HeatSupplyId).HasName("s_heat_supply_pkey");

            entity.ToTable("s_heat_supply");

            entity.Property(e => e.HeatSupplyId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("heat_supply_id");
            entity.Property(e => e.SiteId).HasColumnName("site_id");

            entity.HasOne(d => d.SInfrastructure).WithOne(d => d.HeatSupply)
                .HasForeignKey<SHeatSupply>(d => d.HeatSupplyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_gas_supply_infrastructure_id_fkey");
        });

        modelBuilder.Entity<SPowerSupply>(entity =>
        {
            entity.HasKey(e => e.PowerSupplyId).HasName("s_power_supply_pkey");

            entity.ToTable("s_power_supply");

            entity.Property(e => e.PowerSupplyId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("power_supply_id");
            entity.Property(e => e.SiteId).HasColumnName("site_id");

            entity.HasOne(d => d.SInfrastructure).WithOne(d=> d.PowerSupply)
                .HasForeignKey<SPowerSupply>(d => d.PowerSupplyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_power_supply_site_id_fkey");
        });

        modelBuilder.Entity<SSiteCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("site_characteristic_id");

            entity.ToTable("s_site_characteristics");

            entity.HasIndex(e => e.InnAdministrator, "s_site_characteristics_inn_administrator_key").IsUnique();

            entity.Property(e => e.CadastralNumber)
                .HasColumnType("character varying")
                .HasColumnName("cadastral_number");
            entity.Property(e => e.CadastrolNumber)
                .HasColumnType("character varying")
                .HasColumnName("cadastrol_number");
            entity.Property(e => e.CategoryLand)
                .HasColumnType("character varying")
                .HasColumnName("category_land");
            entity.Property(e => e.CharacteristicsCapitalConstructionFacilitiesLocated).HasColumnName("characteristics_capital_construction_facilities_located");
            entity.Property(e => e.FreeArea).HasColumnName("free_area");
            entity.Property(e => e.FreeLandPlot).HasColumnName("free_land_plot");
            entity.Property(e => e.InnAdministrator)
                .HasColumnType("character varying")
                .HasColumnName("inn_administrator");
            entity.Property(e => e.Link)
                .HasColumnType("character varying")
                .HasColumnName("link");
            entity.Property(e => e.MegevanieLandPlot)
                .HasColumnType("character varying")
                .HasColumnName("megevanie_land_plot");
            entity.Property(e => e.NameAdministrator)
                .HasColumnType("character varying")
                .HasColumnName("name_administrator");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PermittedUseOptions).HasColumnName("permitted_use_options");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.TechnicalCharacteristics).HasColumnName("technical_characteristics");

            entity.HasOne(d => d.Site).WithMany()
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_site_characteristics_site_id_fkey");
        });

        modelBuilder.Entity<SWaterDisposal>(entity =>
        {
            entity.HasKey(e => e.WaterDisposalId).HasName("s_water_disposal_pkey");

            entity.ToTable("s_water_disposal");

            entity.Property(e => e.WaterDisposalId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("water_disposal_id");
            entity.Property(e => e.SiteId).HasColumnName("site_id");

            entity.HasOne(d => d.SInfrastructure).WithOne(d => d.WaterDisposal)
                .HasForeignKey<SWaterDisposal>(d => d.WaterDisposalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_power_supply_site_id_fkey");
        });

        modelBuilder.Entity<SWaterSupply>(entity =>
        {
            entity.HasKey(e => e.WaterSupplyId).HasName("s_water_supply_pkey");

            entity.ToTable("s_water_supply");

            entity.Property(e => e.WaterSupplyId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("water_supply_id");
            entity.Property(e => e.SiteId).HasColumnName("site_id");

            entity.HasOne(d => d.SInfrastructure).WithOne(d => d.WaterSupply)
                .HasForeignKey<SWaterSupply>(d => d.WaterSupplyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_power_supply_site_id_fkey");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("sites_pkey");

            entity.ToTable("sites");

            entity.Property(e => e.SiteId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("site_id");
            entity.Property(e => e.AddressObject)
                .HasColumnType("character varying")
                .HasColumnName("address_object");
            entity.Property(e => e.ClassHazardObject)
                .HasColumnType("character varying")
                .HasColumnName("class_hazard_object");
            entity.Property(e => e.CostObjectMonthlyRent)
                .HasColumnType("character varying")
                .HasColumnName("cost_object_monthly_rent");
            entity.Property(e => e.CostPerHa)
                .HasColumnType("character varying")
                .HasColumnName("cost_per_ha");
            entity.Property(e => e.CostPerSqm)
                .HasColumnType("character varying")
                .HasColumnName("cost_per_sqm");
            entity.Property(e => e.FormOwnershipObject)
                .HasColumnType("character varying")
                .HasColumnName("form_ownership_object");
            entity.Property(e => e.FormTransaction)
                .HasColumnType("character varying")
                .HasColumnName("form_transaction");
            entity.Property(e => e.FormatSite)
                .HasColumnType("character varying")
                .HasColumnName("format_site");
            entity.Property(e => e.MinAndMaxRentalTerms)
                .HasColumnType("character varying")
                .HasColumnName("min_and_max_rental_terms");
            entity.Property(e => e.NamePreferentialTreatmentFacility)
                .HasColumnType("character varying")
                .HasColumnName("name_preferential_treatment_facility");
            entity.Property(e => e.NameSupportInfrastructureFacility)
                .HasColumnType("character varying")
                .HasColumnName("name_support_infrastructure_facility");
            entity.Property(e => e.NumberPreferentialTreatmentFacility)
                .HasColumnType("character varying")
                .HasColumnName("number_preferential_treatment_facility");
            entity.Property(e => e.NumberSupportInfrastructureFacility)
                .HasColumnType("character varying")
                .HasColumnName("number_support_infrastructure_facility");
            entity.Property(e => e.PreferentialTreatment)
                .HasColumnType("character varying")
                .HasColumnName("preferential_treatment");
            entity.Property(e => e.ProcedureDeterminingCost)
                .HasColumnType("character varying")
                .HasColumnName("procedure_determining_cost");
            entity.Property(e => e.SupportInfrastructureFacility)
                .HasColumnType("character varying")
                .HasColumnName("support_infrastructure_facility");
            entity.Property(e => e.TitleSite)
                .HasColumnType("character varying")
                .HasColumnName("title_site");
            entity.Property(e => e.TypeSite)
                .HasColumnType("character varying")
                .HasColumnName("type_site");

            entity.HasOne(d => d.TasLocation).WithOne(d => d.Site)
                .HasForeignKey<TasLocationObject>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("location_object_fkey");

            entity.HasOne(d => d.SAdditionalSiteCharacteristic).WithOne(d => d.Site)
                .HasForeignKey<SAdditionalSiteCharacteristic>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_id_fkey");

            entity.HasOne(d => d.SGasSupplies).WithOne(d => d.Site)
                .HasForeignKey<SGasSupply>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

            entity.HasOne(d => d.SHeatSupply).WithOne(d => d.Site)
                .HasForeignKey<SHeatSupply>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

            entity.HasOne(d => d.SPowerSupply).WithOne(d => d.Site)
                .HasForeignKey<SPowerSupply>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

            entity.HasOne(d => d.SSiteCharacteristic).WithOne(d => d.Site)
                .HasForeignKey<SSiteCharacteristic>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

            entity.HasOne(d => d.SWaterDisposably).WithOne(d => d.Site)
                .HasForeignKey<SWaterDisposal>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

            entity.HasOne(d => d.SWaterSupply).WithOne(d => d.Site)
                .HasForeignKey<SWaterSupply>(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("s_additional_site_characteristics_site_id_fkey");

        });

        modelBuilder.Entity<SpNpa>(entity =>
        {
            entity.HasKey(e => e.SpNpaId).HasName("spnap_id");

            entity.ToTable("sp_npa");

            entity.Property(e => e.DownloadTheNpa)
                .HasColumnType("character varying")
                .HasColumnName("download_the_npa");
            entity.Property(e => e.LinkToNpa)
                .HasColumnType("character varying")
                .HasColumnName("link_to_npa");
            entity.Property(e => e.Requisites).HasColumnName("requisites");
            entity.Property(e => e.SupportMeasuresId).HasColumnName("support_measures_id");

        });

        modelBuilder.Entity<SpSubmissionOfDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("submission_id");
            
            entity.ToTable("sp_submission_of_documents");

            entity.Property(e => e.ApplicationProcedure).HasColumnName("application_procedure");
            entity.Property(e => e.LinkToApplicationForm)
                .HasColumnType("character varying")
                .HasColumnName("link_to_application_form");
            entity.Property(e => e.RequiredDocuments).HasColumnName("required_documents");
            entity.Property(e => e.RequirementsForApplicant).HasColumnName("requirements_for_applicant");
            entity.Property(e => e.SupportMeasuresId).HasColumnName("support_measures_id");

        });

        modelBuilder.Entity<SpSupportMeasure>(entity =>
        {
            entity.HasKey(e => e.SupportMeasuresId).HasName("sp_support_measures_pkey");

            entity.ToTable("sp_support_measures");

            entity.Property(e => e.SupportMeasuresId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("support_measures_id");
            entity.Property(e => e.EntryIntoRegisterSme)
                .HasColumnType("character varying")
                .HasColumnName("entry_into_register_sme");
            entity.Property(e => e.EssenceMechanism).HasColumnName("essence_mechanism");
            entity.Property(e => e.LimitTypeActivity)
                .HasColumnType("character varying")
                .HasColumnName("limit_type_activity");
            entity.Property(e => e.MinInvestVolume)
                .HasColumnType("character varying")
                .HasColumnName("min_invest_volume");
            entity.Property(e => e.NameResponsibleAuthorityAdmin)
                .HasColumnType("character varying")
                .HasColumnName("name_responsible_authority_admin");
            entity.Property(e => e.NameSupportMeasure)
                .HasColumnType("character varying")
                .HasColumnName("name_support_measure");
            entity.Property(e => e.Okved).HasColumnName("OKVED");
            entity.Property(e => e.Region)
                .HasColumnType("character varying")
                .HasColumnName("region");
            entity.Property(e => e.SupportLevel)
                .HasColumnType("character varying")
                .HasColumnName("support_level");
            entity.Property(e => e.TypeSupport)
                .HasColumnType("character varying")
                .HasColumnName("type_support");

            entity.HasOne(d=>d.SpNpa).WithOne(d=>d.SupportMeasures)
                .HasForeignKey<SpNpa>(d=>d.SupportMeasuresId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sp_support_measures_fkey");

            entity.HasOne(d => d.SpSubmissionOfDocument).WithOne(d => d.SupportMeasures)
                .HasForeignKey<SpSubmissionOfDocument>(d => d.SupportMeasuresId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sp_support_measures_withSubmission_fkey");
        });

        modelBuilder.Entity<TasAdministrativeCenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("administrative_id");
            entity.ToTable("tas_administrative_centers");

            entity.Property(e => e.AddressAdministration)
                .HasColumnType("character varying")
                .HasColumnName("address_administration");
            entity.Property(e => e.TechnoparksAndSezId).HasColumnName("technoparks_and_sez_id");
            entity.Property(e => e.TitleAdministration)
                .HasColumnType("character varying")
                .HasColumnName("title_administration");

        });

        modelBuilder.Entity<TasDescriptionObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("description_id");
            entity.ToTable("tas_description_objects");

            entity.Property(e => e.AdditionalServicesMngCompany).HasColumnName("additional_services_mng_company");
            entity.Property(e => e.AvailabilityFreeCustomsZoneRegime)
                .HasColumnType("character varying")
                .HasColumnName("availability_free_customs_zone_regime");
            entity.Property(e => e.InfrastructureAndServices).HasColumnName("infrastructure_and_services");
            entity.Property(e => e.ListIndustry).HasColumnName("list_industry");
            entity.Property(e => e.TechnoparksAndSezId).HasColumnName("technoparks_and_sez_id");

        });

        modelBuilder.Entity<TasFinance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("finance_id");

            entity.ToTable("tas_finance");

            entity.Property(e => e.IncomeTax)
                .HasColumnType("character varying")
                .HasColumnName("income_tax");
            entity.Property(e => e.InsurancePremiums)
                .HasColumnType("character varying")
                .HasColumnName("insurance_premiums");
            entity.Property(e => e.LandTax)
                .HasColumnType("character varying")
                .HasColumnName("land_tax");
            entity.Property(e => e.OtherBenefits).HasColumnName("other_benefits");
            entity.Property(e => e.PropertyTax)
                .HasColumnType("character varying")
                .HasColumnName("property_tax");
            entity.Property(e => e.TechnoparksAndSezId).HasColumnName("technoparks_and_sez_id");
            entity.Property(e => e.TransportTax)
                .HasColumnType("character varying")
                .HasColumnName("transport_tax");
        });

        modelBuilder.Entity<TasLocationObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("location_id");

            entity.ToTable("tas_location_objects");

            entity.Property(e => e.Coordinates)
                .HasColumnType("character varying")
                .HasColumnName("coordinates");
            entity.Property(e => e.MunicipalFormation)
                .HasColumnType("character varying")
                .HasColumnName("municipal_formation");
            entity.Property(e => e.NearestCity)
                .HasColumnType("character varying")
                .HasColumnName("nearest_city");
            entity.Property(e => e.Region)
                .HasColumnType("character varying")
                .HasColumnName("region");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.TechnoparksAndSezId).HasColumnName("technoparks_and_sez_id");

        });

        modelBuilder.Entity<TasTechnoparksAndSez>(entity =>
        {
            entity.HasKey(e => e.TechnoparksAndSezId).HasName("tas_technoparks_and_sez_pkey");

            entity.ToTable("tas_technoparks_and_sez");

            entity.Property(e => e.TechnoparksAndSezId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("technoparks_and_sez_id");
            entity.Property(e => e.Category)
                .HasColumnType("character varying")
                .HasColumnName("category");
            entity.Property(e => e.Documents)
                .HasColumnType("character varying")
                .HasColumnName("documents");
            entity.Property(e => e.HowBecomeResident).HasColumnName("how_become_resident");
            entity.Property(e => e.LinkToWebsite)
                .HasColumnType("character varying")
                .HasColumnName("link_to_website");
            entity.Property(e => e.MinAmountInvestment)
                .HasColumnType("character varying")
                .HasColumnName("min_amount_investment");
            entity.Property(e => e.MinCostRental)
                .HasDefaultValue(0)
                .HasColumnName("min_cost_rental");
            entity.Property(e => e.NumberOfResidents)
                .HasDefaultValue(0)
                .HasColumnName("number_of_residents");
            entity.Property(e => e.Photos)
                .HasColumnType("character varying")
                .HasColumnName("photos");
            entity.Property(e => e.PossibilityBuyingPremises)
                .HasColumnType("character varying")
                .HasColumnName("possibility_buying_premises");
            entity.Property(e => e.RestrictionsTypeActivity).HasColumnName("restrictions_type_activity");
            entity.Property(e => e.SpecialEconomicZone)
                .HasColumnType("character varying")
                .HasColumnName("special_economic_zone");
            entity.Property(e => e.TimeWork)
                .HasColumnType("character varying")
                .HasColumnName("time_work");
            entity.Property(e => e.TitleObject)
                .HasColumnType("character varying")
                .HasColumnName("title_object");
            entity.Property(e => e.Tor).HasColumnName("tor");
            entity.Property(e => e.TotalArea)
                .HasDefaultValueSql("0")
                .HasColumnName("total_area");
            entity.Property(e => e.ValidityPeriod)
                .HasColumnType("character varying")
                .HasColumnName("validity_period");
            entity.Property(e => e.YearOfFormation).HasColumnName("year_of_formation");

            entity.HasOne(d => d.TasAdministrativeCenter).WithOne(d => d.TechnoparksAndSez)
                .HasForeignKey<TasTechnoparksAndSez>(d => d.TechnoparksAndSezId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("administrative_fkey");

            entity.HasOne(d => d.TasDescription).WithOne(d => d.TechnoparksAndSez)
                .HasForeignKey<TasTechnoparksAndSez>(d => d.TechnoparksAndSezId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("description_fkey");

            entity.HasOne(d => d.TasFinance).WithOne(d => d.TechnoparksAndSez)
                .HasForeignKey<TasTechnoparksAndSez>(d => d.TechnoparksAndSezId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("finance_fkey");

            entity.HasOne(d => d.TasLocation).WithOne(d => d.TechnoparksAndSez)
                .HasForeignKey<TasTechnoparksAndSez>(d => d.TechnoparksAndSezId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("location_fkey");


        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
