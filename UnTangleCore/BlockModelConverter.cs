using System;

using UnTangle.Core.Models;
using UnTangle.Core.Models.AmpCab.Amp;
using UnTangle.Core.Models.AmpCab.Amp.Bass;
using UnTangle.Core.Models.AmpCab.Cab;
using UnTangle.Core.Models.AmpCab.Cab.Bass;
using UnTangle.Core.Models.Delay;
using UnTangle.Core.Models.Delay.Legacy;
using UnTangle.Core.Models.Dynamics;
using UnTangle.Core.Models.Distortion;
using UnTangle.Core.Models.Distortion.Legacy;
using UnTangle.Core.Models.EQ;
using UnTangle.Core.Models.Filter;
using UnTangle.Core.Models.FxLoop;
using UnTangle.Core.Models.ImpulseResponse;
using UnTangle.Core.Models.Looper;
using UnTangle.Core.Models.Modulation;
using UnTangle.Core.Models.Reverb;
using UnTangle.Core.Models.Reverb.Legacy;
using UnTangle.Core.Models.SendReturn;
using UnTangle.Core.Models.VolumePan;
using UnTangle.Core.Models.Pitch;
using UnTangle.Core.Models.Wah;

using UnTangle.Core.Strings;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UnTangle.Core
{
    /// <summary>
    /// Class used to map the block to a specific model during deserialization.
    /// </summary>
    public class BlockModelConverter : JsonConverter
    {
        /// <summary>
        /// Property used to signal that this converter does not write.
        /// </summary>
        public override bool CanWrite => false;
        /// <summary>
        /// Property used to signal that this converter can read.
        /// </summary>
        public override bool CanRead => true;

        /// <summary>
        /// Property used to signal whether the incoming type matches a block type.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Block);
        }

        /// <summary>
        /// This class does not serialize.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        /// <summary>
        /// Reads the current block and converts the block type to the specific model type found in the model tag.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            Block modelBlock;

            if (objectType == typeof(Block))
            {
                modelBlock = default(Block);
                string modelType = (string)jsonObject["@model"] ?? string.Empty;
                switch (modelType)
                {
                    #region Amp
                    case ConstAmp.MODEL_ARCHETYPE_CLEAN:
                        modelBlock = new ArchetypeClean();
                        break;
                    case ConstAmp.MODEL_ARCHETYPE_LEAD:
                        modelBlock = new ArchetypeLead();
                        break;
                    case ConstAmp.MODEL_ANGL_METEOR:
                        modelBlock = new ANGLMeteor();
                        break;
                    case ConstAmp.MODEL_GERMAN_MAHADEVA:
                        modelBlock = new GermanMahadeva();
                        break;
                    case ConstAmp.MODEL_JAZZ_RIVET_120:
                        modelBlock = new JazzRivet120();
                        break;
                    case ConstAmp.MODEL_US_SMALL_TWEED:
                        modelBlock = new USSmallTweed();
                        break;
                    case ConstAmp.MODEL_GERMAN_UBERSONIC:
                        modelBlock = new GermanUbersonic();
                        break;
                    case ConstAmp.MODEL_MATCHSTICK_CH1:
                        modelBlock = new MatchstickCh1();
                        break;
                    case ConstAmp.MODEL_MATCHSTICK_CH2:
                        modelBlock = new MatchstickCh2();
                        break;
                    case ConstAmp.MODEL_MATCHSTICK_JUMP:
                        modelBlock = new MatchstickJump();
                        break;
                    case ConstAmp.MODEL_ESSEX_A15:
                        modelBlock = new EssexA15();
                        break;
                    case ConstAmp.MODEL_ESSEX_A30:
                        modelBlock = new EssexA30();
                        break;
                    case ConstAmp.MODEL_WHO_WATT_100:
                        modelBlock = new WhoWatt100();
                        break;
                    case ConstAmp.MODEL_SOUP_PRO:
                        modelBlock = new SoupPro();
                        break;
                    case ConstAmp.MODEL_STONE_AGE_185:
                        modelBlock = new StoneAge185();
                        break;
                    case ConstAmp.MODEL_VOLTAGE_QUEEN:
                        modelBlock = new VoltageQueen();
                        break;
                    case ConstAmp.DISP_TWEED_BLUES_NRM:
                        modelBlock = new TweedBluesNrm();
                        break;
                    case ConstAmp.MODEL_TWEED_BLUES_BRT:
                        modelBlock = new TweedBluesBrt();
                        break;
                    case ConstAmp.MODEL_US_DELUXE_NRM:
                        modelBlock = new USDeluxeNrm();
                        break;
                    case ConstAmp.MODEL_US_DELUXE_VIB:
                        modelBlock = new USDeluxeVib();
                        break;
                    case ConstAmp.MODEL_US_DOUBLE_NRM:
                        modelBlock = new USDoubleNrm();
                        break;
                    case ConstAmp.MODEL_US_DOUBLE_VIB:
                        modelBlock = new USDoubleVib();
                        break;
                    case ConstAmp.MODEL_MAIL_ORDER_TWIN:
                        modelBlock = new MailOrderTwin();
                        break;
                    case ConstAmp.MODEL_DIVIDED_DUO:
                        modelBlock = new DividedDuo();
                        break;
                    case ConstAmp.MODEL_INTERSTATE_ZED:
                        modelBlock = new InterstateZed();
                        break;
                    case ConstAmp.MODEL_DERAILED_INGRID:
                        modelBlock = new DerailedIngrid();
                        break;
                    case ConstAmp.MODEL_MANDARIN_80:
                        modelBlock = new Mandarin80();
                        break;
                    case ConstAmp.MODEL_CALI_RECTIFIRE:
                        modelBlock = new CaliRectifire();
                        break;
                    case ConstAmp.DISP_CALI_IV_LEAD:
                        modelBlock = new CaliIVLead();
                        break;
                    case ConstAmp.MODEL_CALI_IV_R1:
                        modelBlock = new CaliIVR1();
                        break;
                    case ConstAmp.MODEL_CALI_IV_R2:
                        modelBlock = new CaliIVR2();
                        break;
                    case ConstAmp.MODEL_CALI_TEXAS_CH1:
                        modelBlock = new CaliTexasCh1();
                        break;
                    case ConstAmp.MODEL_CALI_TEXAS_CH2:
                        modelBlock = new CaliTexasCh2();
                        break;
                    case ConstAmp.MODEL_BRIT_PLEXI_BRT:
                        modelBlock = new BritPlexiBrt();
                        break;
                    case ConstAmp.MODEL_BRIT_PLEXI_NRM:
                        modelBlock = new BritPlexiNrm();
                        break;
                    case ConstAmp.MODEL_PLACATER_DIRTY:
                        modelBlock = new PlacaterDirty();
                        break;
                    case ConstAmp.MODEL_PLACATER_CLEAN:
                        modelBlock = new PlacaterClean();
                        break;
                    case ConstAmp.MODEL_BRIT_2204:
                        modelBlock = new Brit2204();
                        break;
                    case ConstAmp.MODEL_BRIT_J45_NRM:
                        modelBlock = new BritJ45Nrm();
                        break;
                    case ConstAmp.MODEL_BRIT_J45_BRT:
                        modelBlock = new BritJ45Brt();
                        break;
                    case ConstAmp.MODEL_BRIT_PLEXI_JUMP:
                        modelBlock = new BritPlexiJump();
                        break;
                    case ConstAmp.MODEL_BRIT_TREM_NRM:
                        modelBlock = new BritTremNrm();
                        break;
                    case ConstAmp.MODEL_BRIT_TREM_BRT:
                        modelBlock = new BritTremBrt();
                        break;
                    case ConstAmp.MODEL_BRIT_TREM_JUMP:
                        modelBlock = new BritTremJump();
                        break;
                    case ConstAmp.MODEL_BRIT_P75_NRM:
                        modelBlock = new BritP75Nrm();
                        break;
                    case ConstAmp.MODEL_BRIT_P75_BRT:
                        modelBlock = new BritPlexiBrt();
                        break;
                    case ConstAmp.MODEL_SOLO_LEAD_CLEAN:
                        modelBlock = new SoloLeadClean();
                        break;
                    case ConstAmp.MODEL_SOLO_LEAD_CRUNCH:
                        modelBlock = new SoloLeadCrunch();
                        break;
                    case ConstAmp.MODEL_SOLO_LEAD_OD:
                        modelBlock = new SoloLeadOD();
                        break;
                    case ConstAmp.MODEL_A30_FAWN_NRM:
                        modelBlock = new A30FawnNrm();
                        break;
                    case ConstAmp.MODEL_A30_FAWN_BRT:
                        modelBlock = new A30FawnBrt();
                        break;
                    case ConstAmp.MODEL_PV_PANAMA:
                        modelBlock = new PVPanama();
                        break;
                    case ConstAmp.MODEL_CARTOGRAPHER:
                        modelBlock = new Cartographer();
                        break;
                    case ConstAmp.MODEL_AGUA_51:
                        modelBlock = new Agua51();
                        break;
                    case ConstAmp.MODEL_SV_BEAST_BRT:
                        modelBlock = new SVBeastBrt();
                        break;
                    case ConstAmp.DISP_GCOUGAR_800:
                        modelBlock = new GCougar800();
                        break;
                    case ConstAmp.DISP_DEL_SOL_300:
                        modelBlock = new DelSol300();
                        break;
                    case ConstAmp.MODEL_LINE6_BADONK:
                        modelBlock = new Line6Badonk();
                        break;
                    case ConstAmp.MODEL_LINE6_LITIGATOR:
                        modelBlock = new Line6Litigator();
                        break;
                    case ConstAmp.MODEL_LINE6_FATALITY:
                        modelBlock = new Line6Fatality();
                        break;
                    case ConstAmp.MODEL_LINE6_ELEKTRIK:
                        modelBlock = new Line6Elektrik();
                        break;
                    case ConstAmp.MODEL_LINE6_DOOM:
                        modelBlock = new Line6Doom();
                        break;
                    case ConstAmp.MODEL_LINE6_2204_MOD:
                        modelBlock = new Line62204Mod();
                        break;
                    case ConstAmp.MODEL_LINE6_EPIC:
                        modelBlock = new Line6Epic();
                        break;
                    #endregion Amp




                    #region Cab
                    case ConstCab.MODEL_4X12_GREENBACK_20:
                        modelBlock = new Cab4x12Greenback20();
                        break;
                    case ConstCab.MODEL_4X12_GREENBACK_25:
                        modelBlock = new Cab4x12Greenback25();
                        break;
                    case ConstCab.MODEL_1X12_LEAD_80:
                        modelBlock = new Cab1x12Lead80();
                        break;
                    case ConstCab.MODEL_1X12_MATCH_H30:
                        modelBlock = new Cab1x12MatchH30();
                        break;
                    case ConstCab.MODEL_1X12_MATCH_G25:
                        modelBlock = new Cab1x12MatchG25();
                        break;
                    case ConstCab.MODEL_1X12_BLUE_BELL:
                        modelBlock = new Cab1x12BlueBell();
                        break;
                    case ConstCab.MODEL_4X12_WHO_WATT_100:
                        modelBlock = new Cab4x12WhoWatt100();
                        break;
                    case ConstCab.MODEL_1X6X9_SOUP_PRO_ELLIPSE:
                        modelBlock = new Cab1x6x9SoupProEllipse();
                        break;
                    case ConstCab.MODEL_1X12_FIELD_COIL:
                        modelBlock = new Cab1x12FieldCoil();
                        break;
                    case ConstCab.MODEL_1X12_US_DELUXE:
                        modelBlock = new Cab1x12USDeluxe();
                        break;
                    case ConstCab.MODEL_4X10_TWEED_P10R:
                        modelBlock = new Cab4x10TweedP10R();
                        break;
                    case ConstCab.MODEL_2X12_DOUBLE_C12N:
                        modelBlock = new Cab2x12DoubleC12N();
                        break;
                    case ConstCab.MODEL_2X12_MAIL_C12Q:
                        modelBlock = new Cab2x12MailC12Q();
                        break;
                    case ConstCab.MODEL_1X12_CELEST_12H:
                        modelBlock = new Cab1x12Celest12H();
                        break;
                    case ConstCab.MODEL_2X12_INTERSTATE:
                        modelBlock = new Cab2x12Interstate();
                        break;
                    case ConstCab.MODEL_4X12_CALI_V30:
                        modelBlock = new Cab4X12CaliV30();
                        break;
                    case ConstCab.MODEL_4X12_SOLO_LEAD_EM:
                        modelBlock = new Cab4x12SoloLeadEM();
                        break;
                    case ConstCab.MODEL_2X12_BLUE_BELL:
                        modelBlock = new Cab2x12BlueBell();
                        break;
                    case ConstCab.MODEL_2X12_SILVER_BELL:
                        modelBlock = new Cab2x12SilverBell();
                        break;
                    case ConstCab.MODEL_4X12_UBER_V30:
                        modelBlock = new Cab4x12UberV30();
                        break;
                    case ConstCab.MODEL_4X12_BLACKBACK_30:
                        modelBlock = new Cab4x12Blackback30();
                        break;
                    case ConstCab.MODEL_4X12_1960_T75:
                        modelBlock = new Cab4x121960T75();
                        break;
                    case ConstCab.MODEL_8X10_SV_BEAST:
                        modelBlock = new Cab8x10SVBeast();
                        break;
                    case ConstCab.MODEL_6X10_CALI_POWER:
                        modelBlock = new Cab6x10CaliPower();
                        break;
                    #endregion Cab




                    #region Delay
                    case ConstDelay.MODEL_ADRIATIC_DELAY:
                        modelBlock = new AdriaticDelay();
                        break;
                    case ConstDelay.MODEL_ADRIATIC_SWELL:
                        modelBlock = new AdriaticSwell();
                        break;
                    case ConstDelay.MODEL_DUAL_DELAY:
                        modelBlock = new DualDelay();
                        break;
                    case ConstDelay.MODEL_VINTAGE_DIGITAL_V2:
                        modelBlock = new VintageDigitalV2();
                        break;
                    case ConstDelay.MODEL_SIMPLE_DELAY:
                        modelBlock = new SimpleDelay();
                        break;
                    case ConstDelay.MODEL_TRANSISTOR_TAPE:
                        modelBlock = new TransistorTape();
                        break;
                    case ConstDelay.MODEL_DELAY_COSMOS_ECHO:
                        modelBlock = new CosmosEcho();
                        break;
                    case ConstDelay.MODEL_DELAY_PITCH:
                        modelBlock = new DelayPitch();
                        break;
                    case ConstDelay.MODEL_HARMONY_DELAY:
                        modelBlock = new HarmonyDelay();
                        break;
                    case ConstDelay.MODEL_ELEPHANT_MAN:
                        modelBlock = new ElephantMan();
                        break;
                    case ConstDelay.MODEL_BUCKET_BRIGADE:
                        modelBlock = new BucketBrigade();
                        break;
                    case ConstDelay.MODEL_PING_PONG:
                        modelBlock = new PingPong();
                        break;
                    case ConstDelay.MODEL_SWELL_VINTAGE_DIGITAL:
                        modelBlock = new SwellVintageDigital();
                        break;
                    case ConstDelay.MODEL_DUCKED_DELAY:
                        modelBlock = new DuckedDelay();
                        break;
                    case ConstDelay.MODEL_MOD_CHORUS_ECHO:
                        modelBlock = new ModChorusEcho();
                        break;
                    case ConstDelay.MODEL_SWEEP_ECHO:
                        modelBlock = new SweepEcho();
                        break;
                    case ConstDelay.MODEL_REVERSE_DELAY:
                        modelBlock = new ReverseDelay();
                        break;
                    case ConstDelay.MODEL_DELAY_MULTI_PASS:
                        modelBlock = new MultiPass();
                        break;
                    case ConstDelay.MODEL_LOW_RES:
                        modelBlock = new LowRes();
                        break;
                    case ConstDelay.MODEL_MULTITAP_4:
                        modelBlock = new Multitap4();
                        break;
                    case ConstDelay.MODEL_MULTITAP_6:
                        modelBlock = new Multitap6();
                        break;
                    #endregion Delay




                    #region Distortion
                    case ConstDistortion.MODEL_ARBITRATOR_FUZZ:
                        modelBlock = new ArbitratorFuzz();
                        break;
                    case ConstDistortion.MODEL_BIT_CRUSHER:
                        modelBlock = new BitCrusher();
                        break;
                    case ConstDistortion.MODEL_SCREAM_808:
                        modelBlock = new Scream808();
                        break;
                    case ConstDistortion.MODEL_COMPULSIVE_DRIVE:
                        modelBlock = new CompulsiveDrive();
                        break;
                    case ConstDistortion.MODEL_CLAWTHORN_DRIVE:
                        modelBlock = new ClawthornDrive();
                        break;
                    case ConstDistortion.MODEL_DEEZ_ONE_MOD:
                        modelBlock = new DeezOneMod();
                        break;
                    case ConstDistortion.MODEL_DEEZ_ONE_VINTAGE:
                        modelBlock = new DeezOneVintage();
                        break;
                    case ConstDistortion.MODEL_DERANGEDMASTER:
                        modelBlock = new DerangedMaster();
                        break;
                    case ConstDistortion.MODEL_KINKY_BOOST:
                        modelBlock = new KinkyBoost();
                        break;
                    case ConstDistortion.MODEL_KWB:
                        modelBlock = new KWB();
                        break;
                    case ConstDistortion.MODEL_MEGAPHONE:
                        modelBlock = new Megaphone();
                        break;
                    case ConstDistortion.MODEL_FACIAL_FUZZ:
                        modelBlock = new FacialFuzz();
                        break;
                    case ConstDistortion.MODEL_MINOTAUR:
                        modelBlock = new Minotaur();
                        break;
                    case ConstDistortion.MODEL_HEDGEHOG_D9:
                        modelBlock = new HedgehogD9();
                        break;
                    case ConstDistortion.MODEL_TEEMAH:
                        modelBlock = new Teemah();
                        break;
                    case ConstDistortion.MODEL_HEAVY_DISTORTION:
                        modelBlock = new HeavyDistortion();
                        break;
                    case ConstDistortion.MODEL_INDUSTRIAL_FUZZ:
                        modelBlock = new IndustrialFuzz();
                        break;
                    case ConstDistortion.MODEL_THRIFTER_FUZZ:
                        modelBlock = new ThrifterFuzz();
                        break;
                    case ConstDistortion.MODEL_TOP_SECRET_OD:
                        modelBlock = new TopSecretOD();
                        break;
                    case ConstDistortion.MODEL_TRIANGLE_FUZZ:
                        modelBlock = new TriangleFuzz();
                        break;
                    case ConstDistortion.MODEL_TYCOCTAVIA_FUZZ:
                        modelBlock = new TycoctaviaFuzz();
                        break;
                    case ConstDistortion.MODEL_VERMIN_DIST:
                        modelBlock = new VerminDist();
                        break;
                    case ConstDistortion.MODEL_VALVE_DRIVER:
                        modelBlock = new ValveDriver();
                        break;
                    case ConstDistortion.MODEL_OBSIDIAN_7000:
                        modelBlock = new Obsidian7000();
                        break;
                    case ConstDistortion.MODEL_WRINGER_FUZZ:
                        modelBlock = new WringerFuzz();
                        break;
                    #endregion Distortion




                    #region Dynamics
                    case ConstDynamics.MODEL_LA_STUDIO_COMP:
                        modelBlock = new LASutdioComp();
                        break;
                    case ConstDynamics.MODEL_NOISE_GATE:
                        modelBlock = new NoiseGate();
                        break;
                    case ConstDynamics.MODEL_HARD_GATE:
                        modelBlock = new HardGate();
                        break;
                    case ConstDynamics.MODEL_AUTO_SWELL:
                        modelBlock = new AutoSwell();
                        break;
                    case ConstDynamics.MODEL_RED_SQUEEZE:
                        modelBlock = new RedSqueeze();
                        break;
                    case ConstDynamics.MODEL_DELUXE_COMP:
                        modelBlock = new DeluxeComp();
                        break;
                    case ConstDynamics.MODEL_3_BAND_COMP:
                        modelBlock = new Comp3BandComp();
                        break;
                    case ConstDynamics.MODEL_KINKY_COMP:
                        modelBlock = new KinkyComp();
                        break;
                    #endregion Dynamics



                    #region EQ
                    case ConstEQ.MODEL_LOW_CUT_HIGH_CUT:
                        modelBlock = new LowCutHighCut();
                        break;
                    case ConstEQ.MODEL_GRAPHIC_10_BAND:
                        modelBlock = new Graphic10Band();
                        break;
                    case ConstEQ.MODEL_SIMPLE_3_BAND:
                        modelBlock = new Simple3Band();
                        break;
                    case ConstEQ.MODEL_PARAMETRIC:
                        modelBlock = new Parametric();
                        break;
                    case ConstEQ.MODEL_CALI_Q:
                        modelBlock = new CaliQ();
                        break;
                    #endregion EQ




                    #region FX Loop
                    case ConstFxLoop.MODEL_FX_LOOP_MONO_1:
                        modelBlock = new FXLoopLeft();
                        break;
                    case ConstFxLoop.MODEL_FX_LOOP_MONO_2:
                        modelBlock = new FXLoopRight();
                        break;
                    case ConstFxLoop.MODEL_FX_LOOP_STEREO:
                        modelBlock = new FXLoopStereo();
                        break;
                    #endregion FX Loop



                    #region Filter
                    case ConstFilter.MODEL_AUTO_FILTER:
                        modelBlock = new AutoFilter();
                        break;
                    case ConstFilter.MODEL_MUTANT_FILTER:
                        modelBlock = new MutantFilter();
                        break;
                    case ConstFilter.MODEL_MYSTERY_FILTER:
                        modelBlock = new MysteryFilter();
                        break;
                    #endregion Filter




                    #region  Looper
                    case ConstLooper.MODEL_LOOPER:
                        modelBlock = new Looper();
                        break;
                    #endregion Looper




                    #region Impulse response
                    case ConstIR.MODEL_IMPULSE_RESPONSE_1024:
                        modelBlock = new ImpulseResponse1024();
                        break;
                    case ConstIR.MODEL_IMPULSE_RESPONSE_2048:
                        modelBlock = new ImpulseResponse2048();
                        break;
                    #endregion Impulse Response




                    #region Modulation
                    case ConstModulation.MODEL_60S_BIAS_TRAM:
                        modelBlock = new Mod60sBiasTrem();
                        break;
                    case ConstModulation.MODEL_70S_CHORUS:
                        modelBlock = new Chorus70sChorus();
                        break;
                    case ConstModulation.MODEL_AM_RING_MOD:
                        modelBlock = new AMRingMod();
                        break;
                    case ConstModulation.MODEL_BUBBLE_VIBRATO:
                        modelBlock = new BubbleVibrato();
                        break;
                    case ConstModulation.MODEL_COURTESAN_FLANGE:
                        modelBlock = new CourtesanFlange();
                        break;
                    case ConstModulation.MODEL_DELUXE_PHASER:
                        modelBlock = new DeluxePhaser();
                        break;
                    case ConstModulation.MODEL_DOUBLT_TAKE:
                        modelBlock = new DoubleTake();
                        break;
                    case ConstModulation.MODEL_DYNAMIX_FLANGER:
                        modelBlock = new DynamixFlanger();
                        break;
                    case ConstModulation.MODEL_TRINITY_CHORUS:
                        modelBlock = new TrinityChorus();
                        break;
                    case ConstModulation.MODEL_GRAY_FLANGER:
                        modelBlock = new GrayFlanger();
                        break;
                    case ConstModulation.MODEL_UBIQUITOUS_VIBE:
                        modelBlock = new UbiquitousVibe();
                        break;
                    case ConstModulation.MODEL_SCRIPT_MOD_PHASE:
                        modelBlock = new ScriptModPhase();
                        break;
                    case ConstModulation.DISP_HARMONIC_TREM:
                        modelBlock = new HarmonicTremolo();
                        break;
                    case ConstModulation.MODEL_OPTICAL_TREM:
                        modelBlock = new OpticalTrem();
                        break;
                    case ConstModulation.MODEL_PLASTI_CHORUS:
                        modelBlock = new PlastiChorus();
                        break;
                    case ConstModulation.MODEL_PITCH_RING_MOD:
                        modelBlock = new PitchRingMod();
                        break;
                    case ConstModulation.MODEL_CHORUS:
                        modelBlock = new Chorus();
                        break;
                    case ConstModulation.MODEL_ROTARY_122:
                        modelBlock = new Rotary122();
                        break;
                    case ConstModulation.MODEL_ROTARY_145:
                        modelBlock = new Rotary145();
                        break;
                    case ConstModulation.MODEL_ROTARY_VIBE:
                        modelBlock = new RotaryVibe();
                        break;
                    case ConstModulation.MODEL_HARMONIC_FLANGER:
                        modelBlock = new HarmonicFlanger();
                        break;
                    case ConstModulation.MODEL_BLEAT_CHOP_TREM:
                        modelBlock = new BleatChopTrem();
                        break;
                    case ConstModulation.MODEL_TREMOLO:
                        modelBlock = new Tremolo();
                        break;
                    #endregion Modulation




                    #region Pitch/Synth
                    case ConstPitch.MODEL_PITCH_WHAM:
                        modelBlock = new PitchWham();
                        break;
                    case ConstPitch.MODEL_DUAL_PITCH:
                        modelBlock = new DualPitch();
                        break;
                    case ConstPitch.MODEL_SIMPLE_PITCH:
                        modelBlock = new SimplePitch();
                        break;
                    case ConstPitch.MODEL_TWIN_HARMONY:
                        modelBlock = new TwinHarmony();
                        break;
                    case ConstPitch.MODEL_3_NOTE_GENERATOR:
                        modelBlock = new Synth3NoteGenerator();
                        break;
                    case ConstPitch.MODEL_4_OSC_GENERATOR:
                        modelBlock = new Synth4OSCGenerator();
                        break;
                    case ConstPitch.MODEL_3_OSC_SYNTH:
                        modelBlock = new Synth3OSCSynth();
                        break;
                    #endregion Pitch/Synth




                    #region Reverb
                    case ConstReverb.MODEL_SPRING:
                        modelBlock = new Spring();
                        break;
                    case ConstReverb.MODEL_63_SPRING:
                        modelBlock = new Reverb63Spring();
                        break;
                    case ConstReverb.MODEL_CAVE:
                        modelBlock = new Cave();
                        break;
                    case ConstReverb.MODEL_CHAMBER:
                        modelBlock = new Chamber();
                        break;
                    case ConstReverb.MODEL_DUCKING:
                        modelBlock = new Ducking();
                        break;
                    case ConstReverb.MODEL_ECHO:
                        modelBlock = new Echo();
                        break;
                    case ConstReverb.MODEL_HALL:
                        modelBlock = new Hall();
                        break;
                    case ConstReverb.MODEL_GLITZ:
                        modelBlock = new Glitz();
                        break;
                    case ConstReverb.MODEL_ROOM:
                        modelBlock = new Room();
                        break;
                    case ConstReverb.MODEL_DOUBLE_TANK:
                        modelBlock = new DoubleTank();
                        break;
                    case ConstReverb.MODEL_GANYMEDE:
                        modelBlock = new Ganymede();
                        break;
                    case ConstReverb.MODEL_PARTICLE:
                        modelBlock = new Particle();
                        break;
                    case ConstReverb.MODEL_PLATE:
                        modelBlock = new Plate();
                        break;
                    case ConstReverb.MODEL_OCTO:
                        modelBlock = new Octo();
                        break;
                    case ConstReverb.MODEL_PLATEAUX:
                        modelBlock = new Plateaux();
                        break;
                    case ConstReverb.MODEL_SEARCHLIGHTS:
                        modelBlock = new Searchlights();
                        break;
                    case ConstReverb.MODEL_TILE:
                        modelBlock = new Tile();
                        break;
                    #endregion Reverb




                    #region Send/Return
                    case ConstSendReturn.MODEL_SEND_MONO_1:
                        modelBlock = new SendLeft();
                        break;
                    case ConstSendReturn.MODEL_SEND_MONO_2:
                        modelBlock = new SendRight();
                        break;
                    case ConstSendReturn.MODEL_RETURN_MONO_1:
                        modelBlock = new ReturnLeft();
                        break;
                    case ConstSendReturn.MODEL_RETURN_MONO_2:
                        modelBlock = new ReturnRight();
                        break;
                    case ConstSendReturn.MODEL_SEND_STEREO_1_2:
                        modelBlock = new SendStereoLR();
                        break;
                    case ConstSendReturn.MODEL_RETURN_STEREO_1_2:
                        modelBlock = new ReturnStereoLR();
                        break;
                    #endregion Send/Return




                    #region Volume/Pan
                    case ConstVolPan.MODEL_VOLUME:
                        modelBlock = new Volume();
                        break;
                    case ConstVolPan.MODEL_GAIN:
                        modelBlock = new Gain();
                        break;
                    #endregion Volume/Pan




                    #region Wah
                    case ConstWah.MODEL_CHROME:
                        modelBlock = new Chrome();
                        break;
                    case ConstWah.MODEL_CHROME_CUSTOM:
                        modelBlock = new ChromeCustom();
                        break;
                    case ConstWah.MODEL_COLORFUL:
                        modelBlock = new Colorful();
                        break;
                    case ConstWah.MODEL_CONDUCTOR:
                        modelBlock = new Conductor();
                        break;
                    case ConstWah.MODEL_TEARDROP_310:
                        modelBlock = new Teardrop310();
                        break;
                    case ConstWah.MODEL_THROATY:
                        modelBlock = new Throaty();
                        break;
                    case ConstWah.MODEL_WEEPER:
                        modelBlock = new Weeper();
                        break;
                    case ConstWah.MODEL_FASSEL:
                        modelBlock = new Fassel();
                        break;
                    case ConstWah.MODEL_UK_WAH_846:
                        modelBlock = new UkWah846();
                        break;
                    case ConstWah.MODEL_VETTA_WAH:
                        modelBlock = new Vetta();
                        break;
                    #endregion Wah

                    default:
                        modelBlock = new Block();
                        break;
                }
                serializer.Populate(jsonObject.CreateReader(), modelBlock);
                return modelBlock;
            }
            else
            {
                return default(Block);
            }
        }
    };
}
