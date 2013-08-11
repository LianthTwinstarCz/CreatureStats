using System;

namespace CreatureStats.Informative
{
    // Dynamic Flags
    [Flags]
    public enum DynamicFlags : uint
    {
        UNIT_DYNFLAG_NONE                        = 0x0000, // None
        UNIT_DYNFLAG_LOOTABLE                    = 0x0001, // Lootable
        UNIT_DYNFLAG_TRACK_UNIT                  = 0x0002, // Track Unit
        UNIT_DYNFLAG_TAPPED                      = 0x0004, // Tapped
        UNIT_DYNFLAG_TAPPED_BY_PLAYER            = 0x0008, // Tapped by Player
        UNIT_DYNFLAG_SPECIALINFO                 = 0x0010, // Special Info
        UNIT_DYNFLAG_DEAD                        = 0x0020, // Dead
        UNIT_DYNFLAG_REFER_A_FRIEND              = 0x0040, // Refer a Friend
        UNIT_DYNFLAG_TAPPED_BY_ALL_THREAT_LIST   = 0x0080, // Tapped by all Threat list
    }

    // NPC Flags
    [Flags]
    public enum NPCFlags : uint
    {
        UNIT_NPC_FLAG_NONE                       = 0x00000000, // None
        UNIT_NPC_FLAG_GOSSIP                     = 0x00000001, // Gossip
        UNIT_NPC_FLAG_QUESTGIVER                 = 0x00000002, // Quest Giver
        UNIT_NPC_FLAG_UNK1                       = 0x00000004, // Unknown
        UNIT_NPC_FLAG_UNK2                       = 0x00000008, // Unknown
        UNIT_NPC_FLAG_TRAINER                    = 0x00000010, // Trainer
        UNIT_NPC_FLAG_TRAINER_CLASS              = 0x00000020, // Class Trainer
        UNIT_NPC_FLAG_TRAINER_PROFESSION         = 0x00000040, // Profession Trainer
        UNIT_NPC_FLAG_VENDOR                     = 0x00000080, // Vendor
        UNIT_NPC_FLAG_VENDOR_AMMO                = 0x00000100, // Ammo Vendor
        UNIT_NPC_FLAG_VENDOR_FOOD                = 0x00000200, // Food Vendor
        UNIT_NPC_FLAG_VENDOR_POISON              = 0x00000400, // Poison Vendor
        UNIT_NPC_FLAG_VENDOR_REAGENT             = 0x00000800, // Reagent Vendor
        UNIT_NPC_FLAG_REPAIR                     = 0x00001000, // Repair Vendor
        UNIT_NPC_FLAG_FLIGHTMASTER               = 0x00002000, // Flightmaster
        UNIT_NPC_FLAG_SPIRITHEALER               = 0x00004000, // Spirit Healer
        UNIT_NPC_FLAG_SPIRITGUIDE                = 0x00008000, // Spirit Guide
        UNIT_NPC_FLAG_INNKEEPER                  = 0x00010000, // Innkeeper
        UNIT_NPC_FLAG_BANKER                     = 0x00020000, // Banker
        UNIT_NPC_FLAG_PETITIONER                 = 0x00040000, // Guild Petitioner
        UNIT_NPC_FLAG_TABARDDESIGNER             = 0x00080000, // Tabard Designer
        UNIT_NPC_FLAG_BATTLEMASTER               = 0x00100000, // Battlemaster
        UNIT_NPC_FLAG_AUCTIONEER                 = 0x00200000, // Auctioneer
        UNIT_NPC_FLAG_STABLEMASTER               = 0x00400000, // Stablemaster
        UNIT_NPC_FLAG_GUILD_BANKER               = 0x00800000, // Guild Banker
        UNIT_NPC_FLAG_SPELLCLICK                 = 0x01000000, // Spellclick
        UNIT_NPC_FLAG_PLAYER_VEHICLE             = 0x02000000, // Player is on Vehicle
        UNIT_NPC_FLAG_REFORGER                   = 0x08000000, // Reforging
        UNIT_NPC_FLAG_TRANSMOGRIFIER             = 0x10000000, // Transmogrification
        UNIT_NPC_FLAG_VAULTKEEPER                = 0x20000000, // Void Storage
    }

    // Unit Flags
    [Flags]
    public enum UnitFlags : uint
    {
        UNIT_FLAG_NONE                           = 0x00000000, // None
        UNIT_FLAG_UNK_0                          = 0x00000001, // Unknown
        UNIT_FLAG_NON_ATTACKABLE                 = 0x00000002, // Not Attackable
        UNIT_FLAG_DISABLE_MOVE                   = 0x00000004, // Disable Move
        UNIT_FLAG_PVP_ATTACKABLE                 = 0x00000008, // PvP Attackable
        UNIT_FLAG_RENAME                         = 0x00000010, // Rename allowed
        UNIT_FLAG_PREPARATION                    = 0x00000020, // Preparation
        UNIT_FLAG_UNK_6                          = 0x00000040, // Unknown
        UNIT_FLAG_NOT_ATTACKABLE_1               = 0x00000080, // Not Attackable
        UNIT_FLAG_IMMUNE_TO_PC                   = 0x00000100, // Disables assistance with Player Character (PC)
        UNIT_FLAG_IMMUNE_TO_NPC                  = 0x00000200, // Disables assistance with Non-Player Character (NPC)
        UNIT_FLAG_LOOTING                        = 0x00000400, // Loot Animation
        UNIT_FLAG_PET_IN_COMBAT                  = 0x00000800, // Pet in combat
        UNIT_FLAG_PVP                            = 0x00001000, // PvP
        UNIT_FLAG_SILENCED                       = 0x00002000, // Silenced
        UNIT_FLAG_UNK_14                         = 0x00004000, // Unknown
        UNIT_FLAG_UNK_15                         = 0x00008000, // Unknown
        UNIT_FLAG_UNK_16                         = 0x00010000, // Unknown
        UNIT_FLAG_PACIFIED                       = 0x00020000, // Pacified
        UNIT_FLAG_STUNNED                        = 0x00040000, // Stunned
        UNIT_FLAG_IN_COMBAT                      = 0x00080000, // In Combat
        UNIT_FLAG_TAXI_FLIGHT                    = 0x00100000, // Can't Cast Spells while on Taxi
        UNIT_FLAG_DISARMED                       = 0x00200000, // Disarmed
        UNIT_FLAG_CONFUSED                       = 0x00400000, // Confused
        UNIT_FLAG_FLEEING                        = 0x00800000, // Fleeing
        UNIT_FLAG_PLAYER_CONTROLLED              = 0x01000000, // Player Controlled
        UNIT_FLAG_NOT_SELECTABLE                 = 0x02000000, // Not Selectable
        UNIT_FLAG_SKINNABLE                      = 0x04000000, // Skinnable
        UNIT_FLAG_MOUNT                          = 0x08000000, // Mount
        UNIT_FLAG_UNK_28                         = 0x10000000, // Unknown
        UNIT_FLAG_UNK_29                         = 0x20000000, // Unknown
        UNIT_FLAG_SHEATHE                        = 0x40000000, // Sheathe
        UNIT_FLAG_UNK_31                         = 0x80000000, // Unknown
    }

    // Unit Flags 2
    [Flags]
    public enum UnitFlags2 : uint
    {
        UNIT_FLAG2_FEIGN_DEATH                   = 0x00000001, // Feign Death
        UNIT_FLAG2_UNK1                          = 0x00000002, // Hide unit model
        UNIT_FLAG2_IGNORE_REPUTATION             = 0x00000004, // Ignore reputation
        UNIT_FLAG2_COMPREHEND_LANG               = 0x00000008, // Comprehend language
        UNIT_FLAG2_MIRROR_IMAGE                  = 0x00000010, // Mirror Image
        UNIT_FLAG2_INSTANTLY_APPEAR_MODEL        = 0x00000020, // Unit model instantly appears when summoned
        UNIT_FLAG2_FORCE_MOVEMENT                = 0x00000040, // Force movement
        UNIT_FLAG2_DISARM_OFFHAND                = 0x00000080, // Disarn Off-hand
        UNIT_FLAG2_DISABLE_PRED_STATS            = 0x00000100, // Player has disabled predicted stats
        UNIT_FLAG2_DISARM_RANGED                 = 0x00000400, // <!> This does not disable ranged weapon display
        UNIT_FLAG2_REGENERATE_POWER              = 0x00000800, // Allows regenerating powers
        UNIT_FLAG2_RESTRICT_PARTY_INTERACTION    = 0x00001000, // Restrict interaction to party or raid
        UNIT_FLAG2_PREVENT_SPELL_CLICK           = 0x00002000, // Prevent spellclick
        UNIT_FLAG2_ALLOW_ENEMY_INTERACT          = 0x00004000, // Allow enemy interact
        UNIT_FLAG2_DISABLE_TURN                  = 0x00008000, // Disable turn
        UNIT_FLAG2_UNK2                          = 0x00010000, // Unknown
        UNIT_FLAG2_PLAY_DEATH_ANIM               = 0x00020000, // Plays special death animation upon death
        UNIT_FLAG2_ALLOW_CHEAT_SPELLS            = 0x00040000, // Allows casting spells with AttributesEx7 & SPELL_ATTR7_IS_CHEAT_SPELL
        UNIT_FLAG2_CUSTOM_FAKE_COMBAT            = 0x00080000, // <!> Twinstar custom - fake combat
    };

    // Extra Flags
    [Flags]
    public enum FlagsExtra : uint
    {
        CREATURE_FLAG_EXTRA_NONE                 = 0x00000000, // None
        CREATURE_FLAG_EXTRA_INSTANCE_BIND        = 0x00000001, // Instance Bind
        CREATURE_FLAG_EXTRA_CIVILIAN             = 0x00000002, // No Aggro
        CREATURE_FLAG_EXTRA_NO_PARRY             = 0x00000004, // No Parry
        CREATURE_FLAG_EXTRA_NO_PARRY_HASTEN      = 0x00000008, // No Counter-Attack on Parry
        CREATURE_FLAG_EXTRA_NO_BLOCK             = 0x00000010, // No Block
        CREATURE_FLAG_EXTRA_NO_CRUSH             = 0x00000020, // No Crush Attacks
        CREATURE_FLAG_EXTRA_NO_XP_AT_KILL        = 0x00000040, // No XPs
        CREATURE_FLAG_EXTRA_TRIGGER              = 0x00000080, // Trigger
        CREATURE_FLAG_EXTRA_NO_TAUNT             = 0x00000100, // Taunt Immunity
        CREATURE_FLAG_EXTRA_WORLDEVENT           = 0x00004000, // World Event
        CREATURE_FLAG_EXTRA_GUARD                = 0x00008000, // Guard
        CREATURE_FLAG_EXTRA_NO_CRIT              = 0x00020000, // No Critical Strikes
        CREATURE_FLAG_EXTRA_NO_SKILLGAIN         = 0x00040000, // No Skill Increase
        CREATURE_FLAG_EXTRA_TAUNT_DIMINISH       = 0x00080000, // Diminish Taunt
        CREATURE_FLAG_EXTRA_ALL_DIMINISH         = 0x00100000, // Diminish Effects
        CREATURE_FLAG_EXTRA_DUNGEON_BOSS         = 0x10000000, // Dungeon Boss
    }

    // Type Flags
    [Flags]
    public enum TypeFlags : uint
    {
        CREATURE_TYPEFLAGS_NONE                  = 0x00000000, // None
        CREATURE_TYPEFLAGS_TAMEABLE              = 0x00000001, // Tameable
        CREATURE_TYPEFLAGS_GHOST                 = 0x00000002, // Ghost Visible
        CREATURE_TYPEFLAGS_BOSS                  = 0x00000004, // Boss
        CREATURE_TYPEFLAGS_UNK3                  = 0x00000008, // Unknown
        CREATURE_TYPEFLAGS_UNK4                  = 0x00000010, // Unknown
        CREATURE_TYPEFLAGS_UNK5                  = 0x00000020, // Unknown
        CREATURE_TYPEFLAGS_UNK6                  = 0x00000040, // Unknown
        CREATURE_TYPEFLAGS_DEAD_INTERACT         = 0x00000080, // Dead Interact
        CREATURE_TYPEFLAGS_HERBLOOT              = 0x00000100, // Herbalist Loot
        CREATURE_TYPEFLAGS_MININGLOOT            = 0x00000200, // Miner Loot
        CREATURE_TYPEFLAGS_UNK10                 = 0x00000400, // Unknown
        CREATURE_TYPEFLAGS_MOUNTED_COMBAT        = 0x00000800, // Mounted in Combat
        CREATURE_TYPEFLAGS_AID_PLAYERS           = 0x00001000, // Aid Players
        CREATURE_TYPEFLAGS_UNK13                 = 0x00002000, // Unknown
        CREATURE_TYPEFLAGS_UNK14                 = 0x00004000, // Unknown
        CREATURE_TYPEFLAGS_ENGINEERLOOT          = 0x00008000, // Engineer Loot
        CREATURE_TYPEFLAGS_EXOTIC                = 0x00010000, // Exotic Pet
        CREATURE_TYPEFLAGS_UNK17                 = 0x00020000, // Unknown
        CREATURE_TYPEFLAGS_UNK18                 = 0x00040000, // Unknown
        CREATURE_TYPEFLAGS_UNK19                 = 0x00080000, // Unknown
        CREATURE_TYPEFLAGS_UNK20                 = 0x00100000, // Unknown
        CREATURE_TYPEFLAGS_UNK21                 = 0x00200000, // Unknown
        CREATURE_TYPEFLAGS_UNK22                 = 0x00400000, // Unknown
        CREATURE_TYPEFLAGS_UNK23                 = 0x00800000, // Unknown
        CREATURE_TYPEFLAGS_UNK24                 = 0x01000000, // Unknown
        CREATURE_TYPEFLAGS_UNK25                 = 0x02000000, // Unknown
        CREATURE_TYPEFLAGS_PARTY_MEMBER          = 0x04000000, // Creature can be targeted by spells that require target to be in caster's party/raid
        CREATURE_TYPEFLAGS_UNK27                 = 0x08000000, // Unknown
        CREATURE_TYPEFLAGS_UNK28                 = 0x10000000, // Unknown
        CREATURE_TYPEFLAGS_UNK29                 = 0x20000000, // Unknown
        CREATURE_TYPEFLAGS_UNK30                 = 0x40000000, // Unknown
        CREATURE_TYPEFLAGS_UNK31                 = 0x80000000, // Unknown
    }

    // Unit Class
    [Flags]
    public enum UnitClass : uint
    {
        UNIT_CLASS_WARRIOR                       = 0x1, // Warrior
        UNIT_CLASS_PALADIN                       = 0x2, // Paladin
        UNIT_CLASS_ROGUE                         = 0x4, // Rogue
        UNIT_CLASS_MAGE                          = 0x8, // Mage
    }

    // Creature Type
    public enum CreatureType : uint
    {
        CREATURE_TYPE_BEAST                      = 1, // Beast
        CREATURE_TYPE_DRAGONKIN                  = 2, // Dragonkin
        CREATURE_TYPE_DEMON                      = 3, // Demon
        CREATURE_TYPE_ELEMENTAL                  = 4, // Elemental
        CREATURE_TYPE_GIANT                      = 5, // Giant
        CREATURE_TYPE_UNDEAD                     = 6, // Undead
        CREATURE_TYPE_HUMANOID                   = 7, // Humanoid
        CREATURE_TYPE_CRITTER                    = 8, // Critter
        CREATURE_TYPE_MECHANICAL                 = 9, // Mechanical
        CREATURE_TYPE_NOT_SPECIFIED              = 10, // Not specified
        CREATURE_TYPE_TOTEM                      = 11, // Totem
        CREATURE_TYPE_NON_COMBAT_PET             = 12, // Combat Pet
        CREATURE_TYPE_GAS_CLOUD                  = 13, // Gas Cloud
    }

    // Mechanic Immune Mask
    [Flags]
    public enum MechanicImmuneMask : uint
    {
        MECHANIC_NONE                            = 0x00000000, // None
        MECHANIC_CHARM                           = 0x00000001, // Charm
        MECHANIC_DISORIENTED                     = 0x00000002, // Disorient
        MECHANIC_DISARM                          = 0x00000004, // Disarm
        MECHANIC_DISTRACT                        = 0x00000008, // Distract
        MECHANIC_FEAR                            = 0x00000010, // Fear
        MECHANIC_GRIP                            = 0x00000020, // Grip
        MECHANIC_ROOT                            = 0x00000040, // Root
        MECHANIC_SLOW_ATTACK                     = 0x00000080, // Slow Attack
        MECHANIC_SILENCE                         = 0x00000100, // Silence
        MECHANIC_SLEEP                           = 0x00000200, // Sleep
        MECHANIC_SNARE                           = 0x00000400, // Snare
        MECHANIC_STUN                            = 0x00000800, // Stun
        MECHANIC_FREEZE                          = 0x00001000, // Freeze
        MECHANIC_KNOCKOUT                        = 0x00002000, // Knockout
        MECHANIC_BLEED                           = 0x00004000, // Bleed
        MECHANIC_BANDAGE                         = 0x00008000, // Bandage
        MECHANIC_POLYMORPH                       = 0x00010000, // Polymorph
        MECHANIC_BANISH                          = 0x00020000, // Banish
        MECHANIC_SHIELD                          = 0x00040000, // Shield
        MECHANIC_SHACKLE                         = 0x00080000, // Shackle
        MECHANIC_MOUNT                           = 0x00100000, // Mount
        MECHANIC_INFECTED                        = 0x00200000, // Infected
        MECHANIC_TURN                            = 0x00400000, // Turn
        MECHANIC_HORROR                          = 0x00800000, // Horror
        MECHANIC_INVULNERABILITY                 = 0x01000000, // Invulnerability
        MECHANIC_INTERRUPT                       = 0x02000000, // Interrupt
        MECHANIC_DAZE                            = 0x04000000, // Daze
        MECHANIC_DISCOVERY                       = 0x08000000, // Discovery
        MECHANIC_IMMUNE_SHIELD                   = 0x10000000, // Immune Shield
        MECHANIC_SAPPED                          = 0x20000000, // Sap
        MECHANIC_ENRAGED                         = 0x40000000, // Enrage
        MECHANIC_WOUNDED                         = 0x80000000, // Wounded
    }

    // Family
    public enum Family : uint
    {
        CREATURE_FAMILY_NOT_BEAST                = 0, // Not Beast
        CREATURE_FAMILY_WOLF                     = 1, // Wolf
        CREATURE_FAMILY_CAT                      = 2, // Cat
        CREATURE_FAMILY_SPIDER                   = 3, // Spider
        CREATURE_FAMILY_BEAR                     = 4, // Bear
        CREATURE_FAMILY_BOAR                     = 5, // Boar
        CREATURE_FAMILY_CROCOLISK                = 6, // Crocolisk
        CREATURE_FAMILY_CARRION_BIRD             = 7, // Carrion Bird
        CREATURE_FAMILY_CRAB                     = 8, // Crab
        CREATURE_FAMILY_GORILLA                  = 9, // Gorrila
        CREATURE_FAMILY_HORSE_CUSTOM             = 10, // Horse (Custom)
        CREATURE_FAMILY_RAPTOR                   = 11, // Raptor
        CREATURE_FAMILY_TALLSTRIDER              = 12, // Tallstrider
        CREATURE_FAMILY_FELHUNTER                = 15, // FellHunter
        CREATURE_FAMILY_VOIDWALKER               = 16, // VoidWalker
        CREATURE_FAMILY_SUCCUBUS                 = 17, // Succubus
        CREATURE_FAMILY_DOOMGUARD                = 19, // DoomGuard
        CREATURE_FAMILY_SCORPID                  = 20, // Scorpid
        CREATURE_FAMILY_TURTLE                   = 21, // Turtle
        CREATURE_FAMILY_IMP                      = 23, // Imp
        CREATURE_FAMILY_BAT                      = 24, // Bat
        CREATURE_FAMILY_HYENA                    = 25, // Hyena
        CREATURE_FAMILY_BIRD_OF_PREY             = 26, // Bird of Prey
        CREATURE_FAMILY_WIND_SERPENT             = 27, // Serpent
        CREATURE_FAMILY_REMOTE_CONTROL           = 28, // Remote Control
        CREATURE_FAMILY_FELGUARD                 = 29, // FellGuard
        CREATURE_FAMILY_DRAGONHAWK               = 30, // DragonHawk
        CREATURE_FAMILY_RAVAGER                  = 31, // Ravager
        CREATURE_FAMILY_WARP_STALKER             = 32, // Warp Stalker
        CREATURE_FAMILY_SPOREBAT                 = 33, // SporeBat
        CREATURE_FAMILY_NETHER_RAY               = 34, // Nether Ray
        CREATURE_FAMILY_SERPENT                  = 35, // Serpent
        CREATURE_FAMILY_MOTH                     = 37, // Moth
        CREATURE_FAMILY_CHIMAERA                 = 38, // Chimaera
        CREATURE_FAMILY_DEVILSAUR                = 39, // Devilsaur
        CREATURE_FAMILY_GHOUL                    = 40, // Ghoul
        CREATURE_FAMILY_SILITHID                 = 41, // Silithid
        CREATURE_FAMILY_WORM                     = 42, // Worm
        CREATURE_FAMILY_RHINO                    = 43, // Rhino
        CREATURE_FAMILY_WASP                     = 44, // Wasp
        CREATURE_FAMILY_CORE_HOUND               = 45, // Core Hound
        CREATURE_FAMILY_SPIRIT_BEAST             = 46, // Spirit Beast
        CREATURE_FAMILY_WATER_ELEMENTAL          = 49, // Water Elemental
        CREATURE_FAMILY_FOX                      = 50, // Fox
        CREATURE_FAMILY_MONKEY                   = 51, // Monkey
        CREATURE_FAMILY_DOG                      = 52, // Dog
        CREATURE_FAMILY_BEETLE                   = 53, // Beetle
        CREATURE_FAMILY_SHALE_SPIDER             = 55, // Shale Spider
        CREATURE_FAMILY_ZOMBIE                   = 56, // Zombie
        CREATURE_FAMILY_BEETLE_OLD               = 57, // Beetle (Old)
        CREATURE_FAMILY_SILITHID_2               = 59, // Silithid 2
        CREATURE_FAMILY_WASP_2                   = 66, // Wasp 2
        CREATURE_FAMILY_HYDRA                    = 68, // Hydra
    }

    // Rank
    public enum Rank : uint
    {
        CREATURE_ELITE_NORMAL                    = 0, // Normal
        CREATURE_ELITE_ELITE                     = 1, // Elite
        CREATURE_ELITE_RAREELITE                 = 2, // Rare Elite
        CREATURE_ELITE_WORLDBOSS                 = 3, // World Boss
        CREATURE_ELITE_RARE                      = 4, // Rare
        CREATURE_UNKNOWN                         = 5, // Unknown
    }

    // React States
    enum ReactStates
    {
        REACT_PASSIVE                            = 0, // Passive
        REACT_DEFENSIVE                          = 1, // Defensive
        REACT_AGGRESSIVE                         = 2, // Aggressive
    }

    // Inhabit Type
    [Flags]
    public enum InhabitType : uint
    {
        INHABIT_GROUND                           = 0x1, // Ground
        INHABIT_WATER                            = 0x2, // Water
        INHABIT_AIR                              = 0x4, // Air
        INHABIT_ANYWHERE                         = INHABIT_GROUND | INHABIT_WATER | INHABIT_AIR, // Everywhere
    };

    // Maps
    public enum Maps : uint
    {
        MAP_EASTERN_KINGDOMS                     = 0, // Eastern Kingdoms
        MAP_KALIMDOR                             = 1, // Kalimdor
        MAP_SHADOWFANG_KEEP                      = 33, // Shadowfang Keep
        MAP_UNK_1                                = 34, // Unknown for now! Possible Deadmines?
        MAP_DEADMINES                            = 36, // Deadmines
        MAP_WAILING_CAVERNS                      = 43, // Wailing Caverns
        MAP_RAZORFEN_KRAUL                       = 47, // Razorfen Kraul
        MAP_BLACKFATHOM_DEEPS                    = 48, // Blackfathom Deeps
        MAP_ULDAMAN                              = 70, // Uldaman
        MAP_GNOMEREGAN                           = 90, // Gnomeregan
        MAP_SUNKEN_TEMPLE                        = 109, // Gnomeregan
        MAP_RAZORFEN_DOWNS                       = 129, // Razorfen Downs
        MAP_SCARLET_MONASTERY                    = 189, // Scarlet Monastery
        MAP_ZULFARRAK                            = 209, // Zul'Farrak
        MAP_BLACKROCK_SPIRE                      = 229, // Blackrock Spire
        MAP_BLACKROCK_DEPTHS                     = 230, // Blackrock Depths
        MAP_ONYXIAS_LAIR                         = 249, // Onyxia's Lair
        MAP_DARK_PORTAL                          = 269, // Dark Portal
        MAP_SCHOLOMANCE                          = 289, // Scholomance
        MAP_ZULGURUB                             = 309, // Zul'Gurub
        MAP_STRATHOLME                           = 329, // Stratholme
        MAP_MOLTEN_CORE                          = 409, // Molten Core
        MAP_BLACKWING_LAIR                       = 469, // Blackwing Lair
        MAP_RUINS_OF_AHNQIRAJ                    = 509, // Ruins of Ahn'Qiraj
        MAP_OUTLAND                              = 530, // Outland
        MAP_TEMPLE_OF_AHNQIRAJ                   = 531, // Temple od Ahn'Qiraj
        MAP_KHARAZAN                             = 532, // Kharazan
        MAP_NAXXRAMAS                            = 533, // Naxxramas
        MAP_HYJAL                                = 534, // Mount Hyjal
        MAP_SHATTERED_HALLS                      = 540, // Shattered Halls
        MAP_BLOOD_FURNACE                        = 542, // Blood Furnace
        MAP_HELLFIRE_RAMPARTS                    = 543, // Hellfire Ramparts
        MAP_MAGTHERIDONS_LAIR                    = 544, // Magtheridon's Lair
        MAP_STEAMVAULT                           = 545, // Steamvault
        MAP_SERPENTSHRINE_CAVERNS                = 548, // Serpentshrine Caverns
        MAP_THE_EYE                              = 550, // The Eye
        MAP_ARCATRAZ                             = 552, // Arcatraz
        MAP_MECHANAR                             = 554, // Mechanar
        MAP_SHADOW_LABYRINTH                     = 555, // Shadow Labyrinth
        MAP_SETHEKK_HALLS                        = 556, // Sethekk Halls
        MAP_OLD_HILLSBRAD_FOOTHILLS              = 560, // Old Hillsbrad Foothills
        MAP_BLACK_TEMPLE                         = 564, // Black Temple
        MAP_GRUULS_LAIR                          = 565, // Gruul's Lair
        MAP_ZULAMAN                              = 568, // Zul'Aman
        MAP_NORTHREND                            = 571, // Northrend
        MAP_UTGARDE_KEEP                         = 574, // Utgarde Keep
        MAP_UTGARDE_PINNACLE                     = 575, // Utgarde Pinnacle
        MAP_NEXUS                                = 576, // Nexus
        MAP_OCULUS                               = 578, // Oculus
        MAP_SUNWELL_PLATEAU                      = 580, // Sunwell Plateau
        MAP_MAGISTERS_TERRACE                    = 585, // Magister's Terrace
        MAP_CULLING_OF_STRATHOLME                = 595, // Culling of Stratholme
        MAP_HALLS_OF_STONE                       = 599, // Halls of Stone
        MAP_DRAKTHARON_KEEP                      = 600, // Drak'Tharon Keep
        MAP_AZJOL_NERUB                          = 601, // Azjol Nerub
        MAP_HALLS_OF_LIGHTNING                   = 602, // Halls of Lightning
        MAP_ULDUAR                               = 603, // Ulduar
        MAP_GUNDRAK                              = 604, // Gundrak
        MAP_VIOLET_HOLD                          = 608, // Violet Hold
        MAP_OBSIDIAN_SANCTUM                     = 615, // Obsidian Sanctum
        MAP_EYE_OF_ETERNITY                      = 616, // Eye of Eternity
        MAP_AHNKAHET                             = 619, // Ahn'Kahet
        MAP_VAULT_OF_ARCHAVON                    = 624, // Vault of Archavon
        MAP_ICECROWN_CITADEL                     = 631, // Icecrown Citadel
        MAP_FORGE_OF_SOULS                       = 632, // Forge of Souls
        MAP_TRIAL_OF_THE_CRUSADER                = 649, // Trial of the Crusader
        MAP_TRIAL_OF_THE_CHAMPION                = 650, // Trial of the Champion
        MAP_PIT_OF_SARON                         = 658, // Pit of Saron
        MAP_HALLS_OF_REFLECTION                  = 668, // Halls of Reflection
        MAP_RUBY_SANCTUM                         = 724, // Ruby Sanctum
    }
}
