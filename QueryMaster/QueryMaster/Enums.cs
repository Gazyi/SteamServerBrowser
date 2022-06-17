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
        /// <summary>
        /// CounterStrike 1.6 dedicated server
        /// </summary>
        CounterStrike_1_6_dedicated_server = 90,
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
        /// <summary>
        /// Counter-Strike: Source
        /// </summary>
        CounterStrike_Source = 240,
        /// <summary>
        /// Half-Life: Source
        /// </summary>
        Half_Life_Source = 280,
        /// <summary>
        /// Day of Defeat: Source
        /// </summary>
        Day_Of_Defeat_Source = 300,
        /// <summary>
        /// Half-Life 2: Deathmatch
        /// </summary>
        Half_Life_2_Deathmatch = 320,
        /// <summary>
        /// Half-Life 2: Lost Coast
        /// </summary>
        Half_Life_2_Lost_Coast = 340,
        /// <summary>
        /// Half-Life Deathmatch: Source
        /// </summary>
        Half_Life_Deathmatch_Source = 360,
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
        /// <summary>
        /// Dota 2 
        /// </summary>
        Dota_2 = 570,
        /// <summary>
        /// Portal 2
        /// </summary>
        Portal_2 = 620,
        /// <summary>
        /// Alien Swarm
        /// </summary>
        Alien_Swarm = 630,
        /// <summary>
        /// Counter-Strike: Global Offensive
        /// </summary>
        CounterStrike_Global_Offensive = 730,
        /// <summary>
        /// SiN Episodes: Emergence
        /// </summary>
        SiN_Episodes_Emergence = 1300,
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
        /// <summary>
        /// Vampire The Masquerade - Bloodlines
        /// </summary>
        Vampire_The_Masquerade_Bloodlines = 2600,
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
        /// <summary>
        /// Dino D-Day
        /// </summary>
        Dino_D_Day = 70000,
        /// <summary>
        /// E.Y.E: Divine Cybermancy
        /// </summary>
        E_Y_E_Divine_Cybermancy = 91700,
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
        /// <summary>
        /// Portal: Reloaded
        /// </summary>
        Portal_Reloaded = 1255980,
        /// <summary>
        /// Modular Combat
        /// </summary>
        Modular_Combat = 349480,
        /// <summary>
        /// Bear Party: Adventure
        /// </summary>
        Bear_Party_Adventure = 1274450,
        /// <summary>
        /// Portal:Stories
        /// </summary>
        Portal_Stories = 317400,
        /// <summary>
        /// Cry of Fear
        /// </summary>
        Cry_of_Fear = 223710,
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
        /// Military Conflict: Vietnam
        /// </summary>
        Military_Conflict_Vietnam = 1012110,
        /// <summary>
        /// Thinking with Time Machine
        /// </summary>
        Thinking_with_Time_Machine = 286080,
        /// <summary>
        /// Classic Offensive
        /// </summary>
        Classic_Offensive = 600380,

        // Other third party games that use Steam API and still have servers.
        Red_Orchestra_Ostfront_41_45 = 1200,
        Killing_Floor = 1250,
        Darkest_Hour_Europe_44_45 = 1280,
        Natural_Selection_2 = 4920,
        Sid_Meiers_Civilization_V = 8930,
        Aliens_vs_Predator = 10680,
        Americas_Army_3 = 13140,
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
        Call_of_Duty_Modern_Warfare_3 = 42690,
        Magicka = 42910,
        Homefront = 55100,
        Monday_Night_Combat = 63200,
        Sniper_Elite_V2 = 63380,
        Dungeon_Defenders = 65800,
        Sanctum = 91600,
        Project_Zomboid = 108600,
        XCOM_Enemy_Unknown = 200510,
        Magicka_Wizard_Wars = 202090,
        Americas_Army_Proving_Grounds = 203290,
        Crusader_Kings_II = 203770,
        Serious_Sam_2 = 204340,
        Archeblade = 207230,
        Sanctum_2 = 210770,
        Primal_Carnage = 215470,
        Chivalry_Medieval_Warfare = 219640,
        Grim_Dawn = 219990,
        DayZ_Mod = 224580,
        Wreckfest = 228380,
        Deadfall_Adventures = 231330,
        Killing_Floor_2 = 232090,
        Project_CARS = 234630,
        Mortal_Kombat_Komplete_Edition = 237110,
        Sniper_Elite_3 = 238090,
        The_Forest = 242760,
        Injustice_Gods_Among_Us = 242700,
        Assetto_Corsa = 244210,
        Space_Engineers = 244850,
        Viscera_Cleanup_Detail = 246900,
        Nether = 247730,
        Toribash = 248570,
        Seven_Days_to_Die = 251570,
        Rust = 252490,
        Just_Cause_2_Multiplayer_Mod = 259080,
        Blockstorm = 263060,
        Depth = 274940,
        Creativerse = 280790,
        Life_is_Feudal_Your_Own = 290080,
        Ballistic_Overkill = 296300,
        Miscreated = 299740,
        Road_Redemption = 300380,
        Unturned = 304930,
        Call_of_Duty_Black_Ops_III = 311210,
        Sniper_Elite_4 = 312660,
        Depth_DEV = 316110,
        AXYOS = 318100,
        Primal_Carnage_Extinction = 321360,
        Move_or_Die = 323850,
        SteamVR = 323910,
        Microsoft_Flight_Simulator_X = 314160,
        Dont_Starve_Together = 322330,
        theHunter_Primal = 322920,
        Vagante = 323220,
        Rising_World = 324080,
        Out_of_Reach = 327090,
        Lost_Region = 331810,
        Medieval_Engineers = 333950,
        Vox_Machinae = 334540,
        rFactor = 339790,
        ARK_Survival_Evolved = 346110,
        Hanako_Honor_and_Blade = 349510,
        SURVIVAL_Postapocalypse_Now = 351290,
        Mirage_Arcane_Warfare = 368420,
        Colony_Survival = 366090,
        The_Mean_Greens_Plastic_Warfare = 360940,
        rFactor_2 = 365960,
        Wurm_Unlimited = 366220,
        Angels_Fall_First = 367270,
        Hired_Ops = 374280,
        The_Isle = 376210,
        Thunder_Tier_One = 377300,
        ExoCorps = 368040,
        Project_CARS_2 = 378860,
        In_The_Black = 380110,
        Project_Zomboid_Dedicated_Server = 380870,
        Empyrion_Galactic_Survival = 383120,
        The_Ship_Remasted = 383790,
        Squad = 393380,
        Hurtworld = 393420,
        Tower_Unite = 394690,
        Out_of_Reach_Dedicated_Server = 406800,
        ARK_Survival_Of_The_Fittest = 407530,
        Unfortunate_Spacemen = 408900,
        Forts = 410900,
        Subsistence = 418030,
        Rising_Storm_2_Vietnam = 418460,
        Blackwake = 420290,
        War_of_Rights = 424030,
        Unturned_2 = 427840,
        Automobilista = 431600,
        Spacelords = 436180,
        SQUIDS_FROM_SPACE = 437610,
        Friday_the_13th_The_Game = 438740,
        Midair = 439370,
        Conan_Exiles = 440900,
        Avorion = 445220,
        Automobilista_Dedicated_Server = 447760,
        Citadel_Forged_With_Fire = 487120,
        BATTALION_1944 = 489940,
        Days_of_War = 454350,
        Call_of_Duty_Black_Ops_III_Mod_Tools = 455130,
        Dark_and_Light = 529180,
        Argo = 530700,
        Survive_the_Nights = 541300,
        Stationeers = 544550,
        The_Forest_Dedicated_Server = 556450,
        Witch_It = 559650,
        Serious_Sam_Fusion_2017 = 564310,
        Stormworks_Build_and_Rescue = 573090,
        Remnants = 574180,
        Fog_of_War = 574080,
        Thems_Fightin_Herds = 574980,
        Insurgency_Sandstorm = 581320,
        SBox = 590830,
        PixARK = 593600,
        Mashinky = 598960,
        Barotrauma = 602960,
        Just_Cause_3_Multiplayer_Mod = 619910,
        Ancestors_Legacy = 620590,
        Dungeons_and_Dragons_Dark_Alliance = 623280,
        Dead_Alliance = 626200,
        MORDHAU = 629760,
        Risk_of_Rain_2 = 632360,
        Tanks_VR = 636620,
        Murderous_Pursuits = 638070,
        Jetball = 666590,
        Breeze_of_Death = 668910,
        Solace_Crafting = 670260,
        World_War_3 = 674020,
        Outpost_Zero = 677480,
        Hell_Let_Loose = 686810,
        Tactical_Operations = 690980,
        Fog_Of_War_Free_Edition = 691020,
        Will_To_Live_Online = 707010,
        GridIron = 708720,
        Never_Split_the_Party = 711810,
        Sniper_Elite_V2_Remastered = 728740,
        BattleRush = 734580,
        Post_Scriptum = 736220,
        Operation_Harsh_Doorstop = 736590,
        IL2_Sturmovik_Cliffs_of_Dover_Blitz = 754530,
        Fear_the_Night = 764920,
        Emergency_Call_112_The_Fire_Fighting_Simulation_2 = 785770,
        DARCO_Reign_of_Elements = 789960,
        Warfare_1944 = 793560,
        ATLAS = 834910,
        Outlaws_of_the_Old_West = 840800,
        N1L = 860960,
        Out_of_Reach_Treasure_Royale = 867400,
        BattleRush_2 = 871990,
        SCP_Pandemic = 872670,
        Valheim = 892970,
        LEAP = 906930,
        Prime_and_Load_1776 = 926540,
        Road_to_Eden = 929060,
        Vanguard_Normandy_1944 = 941850,
        World_of_Football = 946880,
        Red_Eclipse = 967460,
        Smashpunks = 1016830,
        DayZ_Experimental = 1024020,
        Kingdomfall = 1030350,
        Beyond_The_Wire = 1058650,
        Automobilista_2 = 1066890,
        Valgrave_Immortal_Plains = 1076500,
        Day_of_Dragons = 1088090,
        Karl_BOOM = 1099470,
        Onset = 1105810,
        Fractured_Veil = 1128500,
        Tip_of_the_Spear_Task_Force_Elite = 1148810,
        Blazing_Sails = 1158940,
        GROUND_BRANCH_CTE = 1202950,
        BadLads = 1200710,
        Survival_Classic = 1203370,
        Midair_Community_Edition = 1231210,
        Frag_Grounds = 1269930,
        Burst_Planet = 1270970,
        Modiverse = 1281150,
        Draconia = 1295900,
        Fadeout_Underground = 1306570,
        Warfare_1944_Test_Environment = 1316360,
        Afterinfection = 1341210,
        Isles_of_Yore = 1360850,
        Myth_of_Empires = 1371580,
        Night_of_the_Dead = 1377380,
        Battle_Cry_of_Freedom = 1358710,
        Animalia_Survival = 1364290,
        Turbo_Sliders_Unlimited = 1478340,
        Hydrofoil_Generation = 1448820,
        Artemishea = 1555220,
        Core_Keeper = 1621690,
        Longvinter = 1635450,
        Smashpunks_Playtest = 1708790,
        BATTLE_STEED_GUNMA_TEST = 1257230,
        PROMOD = 1442170,
        Renown = 1488310,
        Raptor_Territory = 1513860,
        Perfect_Heist_2 = 1521580,
        Dysterra = 1527890,
        GridIron_Playtest = 1535870,
        Kaboom = 1574670,
        Predator_Hunting_Grounds = 1556200,
        Operation_Harsh_Doorstop_Playtest = 1566160,
        Retail_Royale = 1557990,
        Dysterra_Playtest = 1562450,
        V_Rising = 1604030,
        PROMOD_Playtest = 1619270,
        DeadPoly = 1621070,
        BATTLE_STEED_GUNMA = 1661020,
        Kingdom_of_Atham_Crown_of_the_Champions = 1676380,
        World_Titans_War = 1691480,
        CROWZ = 1692070,
        Myth_of_Empires_Dedicated_Server = 1794810,
        Nemesis_Lockdown = 1915550,

        Toxikk = 324810,
        Reflex = 328070,
        QuakeLive = 282440,
        DayZ = 221100,
        Arma_3 = 107410,
        Arma_3_dedicated_server = 233780,
        
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
