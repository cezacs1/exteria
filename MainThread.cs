// [CEZA] Exteria - 2023 mart
namespace ExteriaReversed
{
    public class virtuals
    {
        /*
        public static List<Features> features = new List<Features>();

        public static void create()
        {
            features.Add(new Features());
            features.Add(new Triggerbot());
            features.Add(new Aimbot());
            features.Add(new RecoilControl());
            features.Add(new AutoAccept());
            features.Add(new RGBCrosshair());

            features.Add(new RenderInfo());
            features.Add(new Render());
        }
        */

        //create();

        //foreach (Features virtualfeatures in features)
        //virtualfeatures.start();
        //virtualfeatures.update();
        //virtualfeatures.end();

        //public override void Triggerbot        : Features
        //public override void Aimbot            : Features
        //public override void RecoilControl     : Features
        //public override void AutoAccept        : Features
        //public override void RGBCrosshair      : Features
        //public override void RenderInfo        : Features
        //public override void Render            : Features

        //public static bool Connected           =>  (int)states.Full == gamestate;

        /*
        public enum states
        {
            Null             = 0,
            Challenge        = 1,
            Connected        = 2,
            New              = 3,
            Prespawn         = 4,
            Spawn            = 5,
            Full             = 6,
            Changinglevel    = 7
        }
        */


        //public static int clientstate            = 0;
        //public static int gamestate              = 0;
        //public static int local                  = 0;
        //public static int localhealth            = 0;
        //public static int localteam              = 0;
        //public static int crossid                = 0;
        //public static Vector3 viewangles         = new Vector3(0, 0, 0);
        //public static Vector3 eyeposition        = new Vector3(0, 0, 0);
        //public static int maxplayer              = 0;
        
        /*
        public struct EntityData
        {
            public int id;
            public int address;
            public int health;
            public int team;
            public Vector3 pos;
            public Vector3 bonepos;
            public bool dormant;
        }
        */
        //public static List<EntityData> entities = new List<EntityData>();
        
        
        //public virtual bool Visible(int player)  => Read<bool>(player + Offsets.netvars.m_bSpottedByMask);
        //public static List<string> drawstrings   =  new List<string>();

        
        // Example:
        /*
        public class Features
        {
            public virtual void start()
            {
                local = RPM<int>(Client + Offsets.signatures.dwLocalPlayer);
                localhealth = RPM<int>(local + Offsets.netvars.m_iHealth);
                localteam = RPM<int>(local + Offsets.netvars.m_iTeamNum);

                crossid = RPM<int>(local + Offsets.netvars.m_iCrosshairId);

                viewangles.X = RPM<float>(clientstate + Offsets.signatures.dwClientState_ViewAngles);
                viewangles.Y = RPM<float>(clientstate + Offsets.signatures.dwClientState_ViewAngles + 4);
                viewangles.Z = RPM<float>(clientstate + Offsets.signatures.dwClientState_ViewAngles + 8);
                eyeposition.X = RPM<float>(local + Offsets.netvars.m_vecViewOffset) + RPM<float>(local + Offsets.netvars.m_vecOrigin);
                eyeposition.Y = RPM<float>(local + Offsets.netvars.m_vecViewOffset + 4) + RPM<float>(local + Offsets.netvars.m_vecOrigin + 4);
                eyeposition.Z = RPM<float>(local + Offsets.netvars.m_vecViewOffset + 8) + RPM<float>(local + Offsets.netvars.m_vecOrigin + 8);

                maxplayer = RPM<int>(clientstate + Offsets.signatures.dwClientState_MaxPlayer);
                
                // listeye eklemeden önce var olan verileri temizle
        
                (for int i or foreach player in entityclass)
                {
                int entity = RPM<int>(Client + Offsets.signatures.dwEntityList + i * 0x10);
                int entityhealth = RPM<int>(entity + Offsets.netvars.m_iHealth);
                int entityteam = RPM<int>(entity + Offsets.netvars.m_iTeamNum);
                Vector3 entityposition = RPM<Vector3>(entity + Offsets.netvars.m_vecOrigin);
                bool dormant = RPM<bool>(entity + Offsets.signatures.m_bDormant);
                int BoneMatrix = RPM<int>(entity + Offsets.netvars.m_dwBoneMatrix);
                Vector3 bone = Bone(8, BoneMatrix);

                //Tanımla ve entities'e ekle, sonra tekrar bu listeden oku.
                entitydata.Add(ent);
                }  
            }

            public virtual void update()
            {

            }
            
            public virtual void end()
            {
            
            }

            public virtual bool Visible() // test
            {
                return true;
            }   
        }
        */
        
        /*
        virtual void CanPenetrate(entityindex)
        {
              /*if (maps.parser.BSPClass.Trace(entityindex/*, vec.X, vec.Y, vec.Z, entityindex.getallbones().Closest()).GetTraceValues()) <= 0.1) return false;*/
        
              //return true
        }
        */

        // CEZA
    }
}
