using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueryMaster
{


    /// <summary>
    /// Specifies the type of engine used by server
    /// </summary>
    public enum EngineType
    {
        /// <summary>
        /// Source Engine
        /// </summary>
        Source,
        /// <summary>
        /// Gold Source Engine
        /// </summary>
        GoldSource
    }

    /// <summary>
    /// Specifies the game
    /// </summary>
    public enum Game
    {
        //Gold Source Games
        /// <summary>
        /// Counter-Strike
        /// </summary>
        CounterStrike = 10,
        /// <summary>
        /// Team Fortress Classic
        /// </summary>
        Team_Fortress_Classic = 20,
        /// <summary>
        /// Day Of Defeat
        /// </summary>
        Day_Of_Defeat = 30,
        /// <summary>
        /// Deathmatch Classic
        /// </summary>
        Deathmatch_Classic = 40,
        /// <summary>
        /// Opposing Force
        /// </summary>
        Opposing_Force = 50,
        /// <summary>
        /// Ricochet
        /// </summary>
        Ricochet = 60,
        /// <summary>
        /// Half-Life
        /// </summary>
        Half_Life = 70,
        /// <summary>
        /// Condition Zero
        /// </summary>
        Condition_Zero = 80,
        /*
        /// <summary>
        /// Half-Life Dedicated Server
        /// </summary>
        Half_Life_dedicated_server = 90,
        /// <summary>
        /// Condition Zero Deleted Scenes
        /// </summary>
        Condition_Zero_Deleted_Scenes = 100,
        /// <summary>
        /// Half-Life:Blue Shift
        /// </summary>
        Half_Life_Blue_Shift = 130,
        //Source Games
        /// <summary>
        /// Half-Life 2
        /// </summary>
        Half_Life_2 = 220,
        */
        /// <summary>
        /// Counter-Strike: Source
        /// </summary>
        CounterStrike_Source = 240,
        /*
        /// <summary>
        /// Half-Life: Source
        /// </summary>
        Half_Life_Source = 280,
        */
        /// <summary>
        /// Day of Defeat: Source
        /// </summary>
        Day_Of_Defeat_Source = 300,
        /// <summary>
        /// Half-Life 2: Deathmatch
        /// </summary>
        Half_Life_2_Deathmatch = 320,
        /*
        /// <summary>
        /// Half-Life 2: Lost Coast
        /// </summary>
        Half_Life_2_Lost_Coast = 340,
        */
        /// <summary>
        /// Half-Life Deathmatch: Source
        /// </summary>
        Half_Life_Deathmatch_Source = 360,
        /*
        /// <summary>
        /// Half-Life 2: Episode One
        /// </summary>
        Half_Life_2_Episode_One = 380,
        /// <summary>
        /// Portal
        /// </summary>
        Portal = 400,
        /// <summary>
        /// Half-Life 2: Episode Two
        /// </summary>
        Half_Life_2_Episode_Two = 420,
        */
        /// <summary>
        /// Team Fortress 2
        /// </summary>
        Team_Fortress_2 = 440,
        /// <summary>
        /// Left 4 Dead
        /// </summary>
        Left_4_Dead = 500,
        /// <summary>
        /// Left 4 Dead 2
        /// </summary>
        Left_4_Dead_2 = 550,
        /*
        /// <summary>
        /// Dota 2 
        /// </summary>
        Dota_2 = 570,
        /// <summary>
        /// Portal 2
        /// </summary>
        Portal_2 = 620,
        */
        /// <summary>
        /// Alien Swarm
        /// </summary>
        Alien_Swarm = 630,
        /// <summary>
        /// Counter-Strike: Global Offensive
        /// </summary>
        CounterStrike_Global_Offensive = 730,
        /*
        /// <summary>
        /// SiN Episodes: Emergence
        /// </summary>
        SiN_Episodes_Emergence = 1300,
        */
        /// <summary>
        /// Dark Messiah of Might and Magic
        /// </summary>
        Dark_Messiah_Of_Might_And_Magic = 2100,
        /// <summary>
        /// Dark Messiah Might and Magic Multi-Player
        /// </summary>
        Dark_Messiah_Might_And_Magic_MultiPlayer = 2130,
        /// <summary>
        /// The Ship
        /// </summary>
        The_Ship = 2400,
        /// <summary>
        /// Bloody Good Time
        /// </summary>
        Bloody_Good_Time = 2450,
        /*
        /// <summary>
        /// Vampire The Masquerade - Bloodlines
        /// </summary>
        Vampire_The_Masquerade_Bloodlines = 2600,
        */
        /// <summary>
        /// Garry's Mod
        /// </summary>
        Garrys_Mod = 4000,
        /// <summary>
        /// Zombie Panic! Source
        /// </summary>
        Zombie_Panic_Source = 17500,
        /// <summary>
        /// Age of Chivalry
        /// </summary>
        Age_of_Chivalry = 17510,
        /// <summary>
        /// Synergy
        /// </summary>
        Synergy = 17520,
        /// <summary>
        /// D.I.P.R.I.P.
        /// </summary>
        D_I_P_R_I_P = 17530,
        /// <summary>
        /// Eternal Silence
        /// </summary>
        Eternal_Silence = 17550,
        /// <summary>
        /// Pirates, Vikings, and Knights II
        /// </summary>
        Pirates_Vikings_And_Knights_II = 17570,
        /// <summary>
        /// Dystopia
        /// </summary>
        Dystopia = 17580,
        /// <summary>
        /// INSURGENCY: Modern Infantry Combat
        /// </summary>
        Insurgency_Modern_Infantry_Combat = 17700,
        /// <summary>
        /// Nuclear Dawn
        /// </summary>
        Nuclear_Dawn = 17710,
        /// <summary>
        /// Smashball
        /// </summary>
        Smashball = 17730,

        //Source SDK mod AppIDs and recent GoldSource and Source games.
        /// <summary>
        /// Source SDK 2006
        /// </summary>
        Source_SDK_2006 = 215,
        /// <summary>
        /// Source SDK 2007
        /// </summary>
        Source_SDK_2007 = 218,
        /// <summary>
        /// Source SDK 2013
        /// </summary>
        Source_SDK_2013 = 243750,
        /// <summary>
        /// Jabroni Brawl: Episode 3
        /// </summary>
        Jabroni_Brawl_Episode_3 = 869480,
        /// <summary>
        /// Jabroni Brawl: Episode 3 - Beta Playtest
        /// </summary>
        Jabroni_Brawl_Episode_3_Beta_Playtest = 1617130,
        /// <summary>
        /// Fortress Forever
        /// </summary>
        Fortress_Forever = 253530,
        /// <summary>
        /// Battle Grounds 3
        /// </summary>
        Battle_Grounds_3 = 1057700,
        /// <summary>
        /// IOSoccer
        /// </summary>
        IOSoccer = 673560,
        /// <summary>
        /// Kreedz Climbing
        /// </summary>
        Kreedz_Climbing = 626680,
        /// <summary>
        /// Alien Swarm: Reactive Drop
        /// </summary>
        Alien_Swarm_Reactive_Drop = 563560,
        /*
        /// <summary>
        /// Alien Swarm: Reactive Drop Dedicated Server
        /// </summary>
        Alien_Swarm_Reactive_Drop_Dedicated_Server = 582400,
        */
        /// <summary>
        /// Dino D-Day
        /// </summary>
        Dino_D_Day = 70000,
        /// <summary>
        /// E.Y.E: Divine Cybermancy
        /// </summary>
        E_Y_E_Divine_Cybermancy = 91700,
        /// <summary>
        /// E.Y.E: Divine Cybermancy Demo
        /// </summary>
        E_Y_E_Divine_Cybermancy_Demo = 214820,
        /// <summary>
        /// Contagion
        /// </summary>
        Contagion = 238430,
        /// <summary>
        /// Blade Symphony
        /// </summary>
        Blade_Symphony = 225600,
        /// <summary>
        /// No More Room in Hell
        /// </summary>
        No_More_Room_in_Hell = 224260,
        /*
        /// <summary>
        /// No More Room in Hell Dedicated Server
        /// </summary>
        No_More_Room_in_Hell_Dedicated_Server = 317670,
        */
        /// <summary>
        /// NEOTOKYO
        /// </summary>
        NEOTOKYO = 244630,
        /// <summary>
        /// Insurgency
        /// </summary>
        Insurgency = 222880,
        /// <summary>
        /// Fistful of Frags
        /// </summary>
        Fistful_of_Frags = 265630,
        /// <summary>
        /// Double Action: Boogaloo
        /// </summary>
        Double_Action_Boogaloo = 317360,
        /// <summary>
        /// Black Mesa
        /// </summary>
        Black_Mesa = 362890,
        /*
        /// <summary>
        /// Black Mesa Dedicated Server
        /// </summary>
        Black_Mesa_Dedicated_Server = 346680,
        */
        /// <summary>
        /// Codename CURE
        /// </summary>
        Codename_CURE = 355180,
        /// <summary>
        /// Day of Infamy
        /// </summary>
        Day_of_Infamy = 447820,
        /// <summary>
        /// BrainBread 2
        /// </summary>
        BrainBread_2 = 346330,
        /// <summary>
        /// Empires
        /// </summary>
        Empires = 17740,
        /// <summary>
        /// Action: Source
        /// </summary>
        Action_Source = 977050,
        /// <summary>
        /// Sven Co-op
        /// </summary>
        Sven_Coop = 225840,
        /*
        /// <summary>
        /// Sven Co-op Dedicated Server
        /// </summary>
        Sven_Coop_Dedicated_Server = 276060,
        /// <summary>
        /// Portal: Reloaded
        /// </summary>
        Portal_Reloaded = 1255980,
        /// <summary>
        /// Portal:Stories
        /// </summary>
        Portal_Stories = 317400,
        */
        /// <summary>
        /// Modular Combat
        /// </summary>
        Modular_Combat = 349480,
        /// <summary>
        /// Bear Party: Adventure
        /// </summary>
        Bear_Party_Adventure = 1274450,
        /// <summary>
        /// Cry of Fear
        /// </summary>
        Cry_of_Fear = 223710,
        /*
        /// <summary>
        /// The Stanley Parable
        /// </summary>
        The_Stanley_Parable = 221910,
        /// <summary>
        /// The Stanley Parable Demo
        /// </summary>
        The_Stanley_Parable_Demo = 247750,
        /// <summary>
        /// Aperture Tag: The Paint Gun Testing Initiative
        /// </summary>
        Aperture_Tag = 280740,
        /// <summary>
        /// CONSORTIUM
        /// </summary>
        CONSORTIUM = 264240,
        */
        /// <summary>
        /// Base Defense
        /// </summary>
        Base_Defense = 632730,
        /// <summary>
        /// Treason
        /// </summary>
        Treason = 1786950,
        /// <summary>
        /// Treason Playtest
        /// </summary>
        Treason_Playtest = 1875450,
        /// <summary>
        /// Obsidian Conflict
        /// </summary>
        Obsidian_Conflict = 17750,
        /// <summary>
        /// Firearms: Source
        /// </summary>
        Firearms_Source = 17770,
        /// <summary>
        /// Infestus
        /// </summary>
        Infestus = 656800,
        /// <summary>
        /// Military Conflict: Vietnam
        /// </summary>
        Military_Conflict_Vietnam = 1012110,
        /*
        /// <summary>
        /// Thinking with Time Machine
        /// </summary>
        Thinking_with_Time_Machine = 286080,
        */
        /// <summary>
        /// Classic Offensive
        /// </summary>
        Classic_Offensive = 600380,
        /// <summary>
        /// Lambda Mods
        /// </summary>
        Lambda_Wars = 270370,
        /*
        /// <summary>
        /// The Beginner's Guide
        /// </summary>
        The_Beginners_Guide = 303210,
        /// <summary>
        /// Left 4 Dead 2 Dedicated Server
        /// </summary>
        Left_4_Dead_2_Dedicated_Server = 222860,
        /// <summary>
        /// Half-Life Deathmatch: Source Dedicated Server
        /// </summary>
        Half_Life_Deathmatch_Source_Dedicated_server = 255470,
        */
        /// <summary>
        /// Deathmatch Classic: Refragged
        /// </summary>
        Deathmatch_Classic_Refragged = 1435320,
        /// <summary>
        /// Digital Paintball Redux
        /// </summary>
        Digital_Paintball_Redux = 1066610,
        /// <summary>
        /// JBMod
        /// </summary>
        JBMod = 2158860,
        /// <summary>
        /// Entropy Zero 2 (Modded Co-op)
        /// </summary>
        //Entropy_Zero_2 = 1583720,

        // Other third party games that use Steam API and still have servers.
        Red_Orchestra_Ostfront_41_45 = 1200,
        Red_Orchestra_Ostfront_Beta = 1210,
        Mare_Nostrum = 1230,
        Killing_Floor = 1250,
        Darkest_Hour_Europe_44_45 = 1280,
        SiN_Gold = 1313,
        Natural_Selection_2 = 4920,
        Lost_Planet_Extreme_Condition = 6510,
        Sid_Meiers_Civilization_V = 8930,
        Total_War_EMPIRE = 10500,
        Aliens_vs_Predator = 10680,
        Americas_Army_3 = 13140,
        Unreal_Development_Kit = 13260,
        GROUND_BRANCH = 16900,
        Shattered_Horizon = 18110,
        FEAR_3 = 21100,
        BRINK = 22350,
        Booster_Trooper = 27920,
        Arma_2_Operation_Arrowhead = 33930,
        Total_War_NAPOLEON = 34030,
        Total_War_SHOGUN_2 = 34330,
        Red_Orchestra_2 = 35450,
        Moonbase_Alpha = 39000,
        Serious_Sam_HD_The_First_Encounter = 41000,
        Serious_Sam_HD_The_Second_Encounter = 41010,
        Serious_Sam_3 = 41070,
        Lead_and_Gold_Gangs_of_the_Wild_West = 42120,
        Call_of_Duty_Modern_Warfare_3 = 42690,
        Magicka = 42910,
        The_Haunted_Hells_Reach = 43190,
        Plain_Sight = 49900,
        Spec_Ops_The_Line = 50300,
        Homefront = 55100,
        Monday_Night_Combat = 63200,
        Sniper_Elite_V2 = 63380,
        IL_2_Sturmovik_Cliffs_of_Dover = 63950,
        Arma_2_Private_Military_Company = 65720,
        Take_On_Helicopters = 65730,
        Dungeon_Defenders = 65800,
        Breach = 72300,
        Sanctum = 91600,
        ORION_Prelude = 104900,
        Project_Zomboid = 108600,
        Guardians_of_Middle_earth = 111900,
        XCOM_Enemy_Unknown = 200510,
        Magicka_Wizard_Wars = 202090,
        Americas_Army_Proving_Grounds = 203290,
        Crusader_Kings_II = 203770,
        Serious_Sam_2 = 204340,
        Archeblade = 207230,
        ENDLESS_Space_Definitive_Edition = 208140,
        Batman_Arkham_Origins = 209000,
        Sanctum_2 = 210770,
        Sonic_and_All_Stars_Racing_Transformed_Collection = 212480,
        Painkiller_Hell_and_Damnation = 214870,
        Primal_Carnage = 215470,
        Chivalry_Medieval_Warfare = 219640,
        Grim_Dawn = 219990,
        //Chivalry_Medieval_Warfare_Dedicated_Server = 220070,
        DayZ_Mod = 224580,
        Euro_Truck_Simulator_2 = 227300,
        Scourge_Outbreak = 227560,
        Wreckfest = 228380,
        //Painkiller_Hell_And_Damnation_Dedicated_Server = 230030,
        War_for_the_Overworld = 230190,
        Deadfall_Adventures = 231330,
        Killing_Floor_2 = 232090,
        Project_CARS = 234630,
        Takedown_Red_Sabre = 236510,
        Europa_Universalis_IV = 236850,
        Mortal_Kombat_Komplete_Edition = 237110,
        Planet_Explorers = 237870,
        Sniper_Elite_3 = 238090,
        The_Forest = 242760,
        Injustice_Gods_Among_Us = 242700,
        Gas_Guzzlers_Extreme = 243800,
        Take_On_Mars = 244030,
        Assetto_Corsa = 244210,
        Space_Engineers = 244850,
        Strike_Vector = 246700,
        Viscera_Cleanup_Detail = 246900,
        Nether = 247730,
        Toribash = 248570,
        Seven_Days_to_Die = 251570,
        Zombie_Tycoon_2_Brainhovs_Revenge = 252270,
        Rust = 252490,
        Tiny_Brains = 253690,
        Viscera_Cleanup_Detail_Shadow_Warrior = 255520,
        Just_Cause_2_Multiplayer_Mod = 259080,
        Eden_Star = 259570,
        Blockstorm = 263060,
        Zombie_Grinder = 263920,
        Viscera_Cleanup_Detail_Santas_Rampage = 265210,
        XCOM_2 = 268500,
        American_Truck_Simulator = 270880,
        Dungeon_Lords = 271760,
        Depth = 274940,
        Creativerse = 280790,
        Masterspace = 282860,
        Life_is_Feudal_Your_Own = 290080,
        H_Hour_Worlds_Elite = 293220,
        //Seven_Days_to_Die_Dedicated_Server = 294420,
        Ballistic_Overkill = 296300,
        Real_Boxing = 296770,
        Heroes_of_Might_and_Magic_III_HD_Edition = 297000,
        Miscreated = 299740,
        Road_Redemption = 300380,
        Chicken_Invaders_4 = 301300,
        //Miscreated_Dedicated_Server = 302200,
        BlazeRush = 302710,
        Unturned = 304930,
        Minigame_Game = 305900,
        NS2_Combat = 310110,
        Sky_Nations = 310760,
        Call_of_Duty_Black_Ops_III = 311210,
        Rain_World = 312520,
        Sniper_Elite_4 = 312660,
        Depth_DEV = 316110,
        AXYOS = 318100,
        Primal_Carnage_Extinction = 321360,
        Supraball = 321400,
        Move_or_Die = 323850,
        SteamVR = 323910,
        Microsoft_Flight_Simulator_X = 314160,
        Dont_Starve_Together = 322330,
        theHunter_Primal = 322920,
        Vagante = 323220,
        Rising_World = 324080,
        Sky_Nations_Demo = 326220,
        Out_of_Reach = 327090,
        Lost_Region = 331810,
        LEGO_Worlds = 332310,
        GRAV = 332500,
        Medieval_Engineers = 333950,
        Down_To_One = 334040,
        Vox_Machinae = 334540,
        Grimoire_Manastorm = 335430,
        Ukrainian_Ninja = 339000,
        rFactor = 339790,
        NASCAR_15_Victory_Edition = 345890,
        ARK_Survival_Evolved = 346110,
        Hanako_Honor_and_Blade = 349510,
        SURVIVAL_Postapocalypse_Now = 351290,
        Chicken_Invaders_5 = 353090,
        //Wreckfest_Dedicated_Server = 361580,
        Mirage_Arcane_Warfare = 368420,
        Colony_Survival = 366090,
        The_Mean_Greens_Plastic_Warfare = 360940,
        rFactor_2 = 365960,
        Wurm_Unlimited = 366220,
        Savage_Resurrection = 366440,
        Angels_Fall_First = 367270,
        ExoCorps = 368040,
        Hired_Ops = 374280,
        //Zombie_Grinder_Dedicated_Server = 374980,
        //ARK_Survival_Evolved_Dedicated_Server = 376030,
        The_Isle = 376210,
        Hide_and_Hold_Out_H2o = 377140,
        Thunder_Tier_One = 377300,
        Chicken_Invaders_3 = 377460,
        Project_CARS_2 = 378860,
        In_The_Black = 380110,
        //Project_Zomboid_Dedicated_Server = 380870,
        Empyrion_Galactic_Survival = 383120,
        The_Ship_Remasted = 383790,
        Flight_Sim_World = 389280,
        PCE_Open_Testing_Beta = 392990,
        Squad = 393380,
        Hurtworld = 393420,
        Ice_Lakes = 393430,
        GearStorm = 393800,
        Tower_Unite = 394690,
        //Out_of_Reach_Dedicated_Server = 406800,
        ARK_Survival_Of_The_Fittest = 407530,
        Unfortunate_Spacemen = 408900,
        Forts = 410900,
        BATTLECREW_Space_Pirates = 411480,
        The_Black_Death = 412450,
        //Ballistic_Overkill_Dedicated_Server = 416880,
        Subsistence = 418030,
        Rising_Storm_2_Vietnam = 418460,
        Lifeless = 419520,
        Blackwake = 420290,
        War_of_Rights = 424030,
        Farm_Expert_2017 = 424590,
        Unturned_2 = 427840,
        Feed_and_Grow_Fish = 429050,
        Alchemists_Awakening = 431450,
        Automobilista = 431600,
        Marvel_Ultimate_Alliance = 433300,
        Marvel_Ultimate_Alliance_2 = 433320,
        Formicide = 434510,
        Spacelords = 436180,
        SQUIDS_FROM_SPACE = 437610,
        Friday_the_13th_The_Game = 438740,
        Midair = 439370,
        Conan_Exiles = 440900,
        Zaccaria_Pinball = 444930,
        Avorion = 445220,
        //Automobilista_Dedicated_Server = 447760,
        Chicken_Invaders_2 = 449550,
        The_Lab = 450390,
        Final_Days = 459830,
        Strike_Vector_EX = 476360,
        Citadel_Forged_With_Fire = 487120,
        BATTALION_1944 = 489940,
        Days_of_War = 454350,
        //Call_of_Duty_Black_Ops_III_Mod_Tools = 455130,
        Rokh = 462440,
        Dream_Car_Builder = 488550,
        Virtual_Warfighter = 517020,
        Zescape = 517280,
        Satisfactory = 526870,
        Dark_and_Light = 529180,
        Argo = 530700,
        Survive_the_Nights = 541300,
        Stationeers = 544550,
        //Call_of_Duty_Black_Ops_III_Unranked_Dedicated_Server = 545990,
        //The_Forest_Dedicated_Server = 556450,
        Witch_It = 559650,
        Serious_Sam_Fusion_2017 = 564310,
        Fire_Pro_Wrestling_World = 564230,
        Witch_It_Beta = 567920,
        Stormworks_Build_and_Rescue = 573090,
        Remnants = 574180,
        Fog_of_War = 574080,
        Thems_Fightin_Herds = 574980,
        Dead_Matter = 575440,
        Golem_Gates = 575970,
        Demolish_and_Build_2018 = 577670,
        Insurgency_Sandstorm = 581320,
        //Insurgency_Sandstorm_Dedicated_Server = 581330,
        Capsa = 588120,
        Cobalt_WASD = 590720,
        SBox = 590830,
        PixARK = 593600,
        Hide_and_Seek = 596940,
        Mashinky = 598960,
        qb = 601400,
        Barotrauma = 602960,
        The_Archotek_Project = 608990,
        Task_Force = 611300,
        Just_Cause_3_Multiplayer_Mod = 619910,
        Ancestors_Legacy = 620590,
        Dungeons_and_Dragons_Dark_Alliance = 623280,
        Dead_Alliance = 626200,
        MORDHAU = 629760,
        Risk_of_Rain_2 = 632360,
        Tanks_VR = 636620,
        Murderous_Pursuits = 638070,
        Airmen = 647740,
        Jetball = 666590,
        Urban_Terror = 659280,
        The_Warhorn = 660920,
        Rival_Rampage = 663690,
        //Capsa_Dedicated_Server = 667230,
        Breeze_of_Death = 668910,
        Solace_Crafting = 670260,
        WarFallen = 672040,
        World_War_3 = 674020,
        Pantropy = 677180,
        Outpost_Zero = 677480,
        Hell_Let_Loose = 686810,
        Territory_Control_2 = 690290,
        Tactical_Operations = 690980,
        Fog_of_War_Free_Edition = 691020,
        Master_Arena = 704020,
        Will_To_Live_Online = 707010,
        GridIron = 708720,
        Never_Split_the_Party = 711810,
        Beasts_of_Bermuda = 719890,
        Islands_of_Nyne_Battle_Royale = 728540,
        Sniper_Elite_V2_Remastered = 728740,
        BattleRush = 734580,
        Post_Scriptum = 736220,
        Operation_Harsh_Doorstop = 736590,
        Villages = 749820,
        Egress = 750800,
        Fractured_Lands = 751240,
        IL2_Sturmovik_Cliffs_of_Dover_Blitz = 754530,
        Fear_the_Night = 764920,
        Squad_Public_Testing = 774941,
        Team_Sonic_Racing = 785260,
        Emergency_Call_112_The_Fire_Fighting_Simulation_2 = 785770,
        Perfect_Heist = 787040,
        DARCO_Reign_of_Elements = 789960,
        Identity = 792990,
        Warfare_1944 = 793560,
        TO4_Alpha = 795270,
        Swords_n_Magic_and_Stuff = 810040,
        HELLS_NEW_WORLD = 823350,
        Hellbreath = 826270,
        ATLAS = 834910,
        Outlaws_of_the_Old_West = 840800,
        Post_Scriptum_Public_Testing = 844630,
        Super_Versus = 845660,
        N1L = 860960,
        Out_of_Reach_Treasure_Royale = 867400,
        World_of_Zombies = 869130,
        BattleRush_2 = 871990,
        SCP_Pandemic = 872670,
        Kronorite = 876780,
        //SCP_Pandemic_Dedicated_Server = 884110,
        Nova_Life_Amboise = 885570,
        Insurgency_Sandstorm_Community_Test_Environment = 887860,
        StickyBots = 889400,
        Valheim = 892970,
        LEAP = 906930,
        VALHALL_Harbinger = 908740,
        Miscreated_Experimental_Server = 912290,
        Prime_and_Load_1776 = 926540,
        Road_to_Eden = 929060,
        Brutal_Grounds = 941610,
        Vanguard_Normandy_1944 = 941850,
        Bravery_and_Greed = 943370,
        Starcross_Arena = 945870,
        World_of_Football = 946880,
        Dysterra_RM = 950410,
        Red_Eclipse = 967460,
        Re_Poly = 970300,
        //Never_Split_the_Party_Dedicated_Server = 976380,
        Medieval_Towns = 982760,
        Nether_The_Untold_Chapter = 1010270,
        Smashpunks = 1016830,
        DayZ_Experimental = 1024020,
        Flea_Madness = 1025560,
        Kingdomfall = 1030350,
        Fragsurf = 1033410,
        Deep_Space_Battle_Simulator = 1055610,
        Beyond_The_Wire = 1058650,
        Eighty_Three = 1059220,
        Automobilista_2_Beta = 1066880,
        Automobilista_2 = 1066890,
        Valgrave_Immortal_Plains = 1076500,
        Day_of_Dragons = 1088090,
        //Day_of_Dragons_Dedicated_Server = 1088320,
        Operation_Valor = 1095480,
        Karl_BOOM = 1099470,
        Onset = 1105810,
        //Unturned_Dedicated_Server = 1110390,
        TrenchesWIP = 1118920,
        Fractured_Veil = 1128500,
        Escape_from_Labyrinth = 1113640,
        Tidewoken = 1135220,
        Tip_of_the_Spear_Task_Force_Elite = 1148810,
        Icarus = 1149460,
        Blazing_Sails = 1158940,
        GROUND_BRANCH_CTE = 1202950,
        Talvisota_Winter_War = 1206240,
        BadLads = 1200710,
        Survival_Classic = 1203370,
        Pangea_Survival = 1204700,
        Midair_Community_Edition = 1231210,
        //Stormworks_Dedicated_Server = 1247090,
        Frag_Grounds = 1269930,
        Burst_Planet = 1270970,
        Modiverse = 1281150,
        Gemini_Binary_Conflict = 1293660,
        Draconia = 1295900,
        Slurkum = 1302480,
        Fadeout_Underground = 1306570,
        Operation_Harsh_Doorstop_Test_Environment = 1307180,
        Last_Gang_Standing = 1309760,
        Tidewoken_Demo = 1315790,
        Warfare_1944_Test_Environment = 1316360,
        Flea_Madness_Demo = 1326090,
        //Automobilista_2_Dedicated_Server = 1338040,
        Afterinfection = 1341210,
        Survival_Lost_Way = 1343520,
        Nemesis_Distress = 1343620,
        Calturin_and_Clone = 1359110,
        Isles_of_Yore = 1360850,
        Motor_Town_Behind_The_Wheel = 1369670,
        Myth_of_Empires = 1371580,
        Sanctuary_Island = 1377010,
        Night_of_the_Dead = 1377380,
        Battle_Cry_of_Freedom = 1358710,
        Animalia_Survival = 1364290,
        Blood_Oath_When_The_Sword_Rises = 1399190,
        TrickShot_Demo = 1410970,
        BEACHED = 1412190,
        //Night_of_the_Dead_Dedicated_Server = 1420710,
        The_Cartesian_Project = 1423400,
        The_Ultimate_Game = 1437370,
        Turbo_Sliders_Unlimited = 1478340,
        Hydrofoil_Generation = 1448820,
        Reign_and_Ruin = 1454220,
        Dysterra_RM_Test_Server = 1455470,
        The_Dark_World_Edge_of_Eternity = 1481060,
        Chicken_Invaders_Universe = 1510460,
        Sausage_Fiesta = 1540840,
        Artemishea = 1555220,
        Core_Keeper = 1621690,
        Longvinter = 1635450,
        Era_of_Combat_Boxing = 1687100,
        Smashpunks_Playtest = 1708790,
        BATTLE_STEED_GUNMA_TEST = 1257230,
        PROMOD = 1442170,
        Blood_Oath_When_The_Sword_Rises_Playtest = 1470010,
        Renown = 1488310,
        Carrier_Command_2 = 1489630,
        Impostors = 1496970,
        Hell_Let_Loose_Public_Testing = 1504860,
        Raptor_Territory = 1513860,
        Perfect_Heist_2 = 1521580,
        Dysterra = 1527890,
        Solys = 1537920,
        Cartels = 1539760,
        GridIron_Playtest = 1535870,
        Retail_Royale = 1557990,
        FortressCraft_Chapter_1 = 1558210,
        Predator_Hunting_Grounds = 1556200,
        Operation_Harsh_Doorstop_Playtest = 1566160,
        Dysterra_Playtest = 1562450,
        Goose_Goose_Duck = 1568590,
        Flea_Madness_Playtest = 1574380,
        Chunkers = 1574420,
        Kaboom = 1574670,
        WWII_Online_Chokepoint = 1576780,
        Snow_War = 1585100,
        V_Rising = 1604030,
        Drakes_Odds_Survive = 1607930,
        SmallZ = 1612520,
        PROMOD_Playtest = 1619270,
        DeadPoly = 1621070,
        Survivals_unknown = 1624640,
        Tag_Hop = 1625330,
        QANGA = 1648190,
        Medieval_Towns_Playtest = 1655830,
        //Crypto_Shooter_Demo = 1656270,
        BATTLE_STEED_GUNMA = 1661020,
        Dead_Survival = 1665490,
        Kingdom_of_Atham_Crown_of_the_Champions = 1676380,
        Joint_War = 1681730,
        Powerjackers_VR_Superhero_Battle_Royale = 1686070,
        World_Titans_War = 1691480,
        CROWZ = 1692070,
        Solys_Playtest = 1692440,
        ScrewUp = 1695670,
        Axial_Drift = 1707030,
        Badlands = 1714350,
        Dysterra_Demo = 1724820,
        Astral_Shipwright = 1728180,
        Shattle = 1730580,
        Xio_Survival = 1736680,
        Dead_District = 1772910,
        //Myth_of_Empires_Dedicated_Server = 1794810,
        Shattle_Playtest = 1817990,
        Minigame_Madness_Demo = 1827800,
        Olympian_Knights = 1833860,
        nanos_world = 1841660,
        Obscurity_Unknown_Threat_Playtest = 1843870,
        Farmer_Toon = 1848910,
        Project_Speed_2 = 1863910,
        //Cardfight_Vanguard_Dear_Days = 1881420,
        Nemesis_Lockdown = 1915550,
        I_D_F_K = 1936430,
        KAOS_SurVival = 1947280,
        Ghosts_Of_Tabor = 1957780,
        Zero_World = 1973280,
        Zero_World_Playtest = 1973390,
        Astral_Shipwright_Demo = 1993250,
        Ghosts_of_Tabor_Playtest = 2003160,
        Territory_Control_2_Demo = 2052980,
        VEIN_Demo = 2082470,
        LAZ3RZ = 2107280,
        LAZ3RZ_Playtest = 2108350,
        Bravery_and_Greed_Demo = 2127170,
        Wrangel_Island = 2122570,
        Wrangel_Island_Playtest = 2123060,
        Degen_Royale = 2156070,
        Degen_Royale_Playtest = 2193610,

        Toxikk = 324810,
        Reflex = 328070,
        QuakeLive = 282440,
        DayZ = 221100,
        Arma_3 = 107410,
        //Arma_3_dedicated_server = 233780,
        
    }

    /// <summary>
    /// Specifies the Region
    /// </summary>
    public enum Region : byte
    {
        /// <summary>
        /// US East coast 
        /// </summary>
        US_East_coast,
        /// <summary>
        /// 	US West coast 
        /// </summary>
        US_West_coast,
        /// <summary>
        /// South America
        /// </summary>
        South_America,
        /// <summary>
        /// Europe
        /// </summary>
        Europe,
        /// <summary>
        /// Asia
        /// </summary>
        Asia,
        /// <summary>
        /// Australia
        /// </summary>
        Australia,
        /// <summary>
        /// Middle East 
        /// </summary>
        Middle_East,
        /// <summary>
        /// Africa
        /// </summary>
        Africa,
        /// <summary>
        /// Rest of the world 
        /// </summary>
        Rest_of_the_world = 0xFF
    }

    enum SocketType
    {
        Udp,
        Tcp
    }

    enum ResponseMsgHeader : byte
    {
        A2S_INFO = 0x49,
        A2S_INFO_Obsolete = 0x6D,
        A2S_PLAYER = 0x44,
        A2S_RULES = 0x45,
        A2S_SERVERQUERY_GETCHALLENGE = 0x41,
    }

    //Used in Source Rcon
    enum PacketId
    {
        Empty = 10,
        ExecCmd = 11
    }

    enum PacketType
    {
        Auth = 3,
        AuthResponse = 2,
        Exec = 2,
        ExecResponse = 0
    }







}
