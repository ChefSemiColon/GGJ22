/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_AMB_BLEND = 2001508374U;
        static const AkUniqueID PLAY_ENEMY_LAND = 4163225046U;
        static const AkUniqueID PLAY_ENEMY_VOCALS = 2855648523U;
        static const AkUniqueID PLAY_GRAVITY_SWITCH = 3240456823U;
        static const AkUniqueID PLAY_IN_GAME = 3671131488U;
        static const AkUniqueID PLAY_MAIN_MENU = 3306210749U;
        static const AkUniqueID PLAY_OBJECT_LAND = 3883907685U;
        static const AkUniqueID PLAY_PC_DEATH = 228649394U;
        static const AkUniqueID PLAY_PC_FOOTSTEPS = 485331593U;
        static const AkUniqueID PLAY_PC_LAND = 4210120443U;
        static const AkUniqueID PLAY_UI_RETRY = 1133542507U;
        static const AkUniqueID PLAY_UI_START = 643450781U;
        static const AkUniqueID PLAY_UI_STOP = 1019176095U;
        static const AkUniqueID STOP_ALL = 452547817U;
        static const AkUniqueID STOP_IN_GAME = 228472158U;
        static const AkUniqueID STOP_MAIN_MENU = 774860123U;
        static const AkUniqueID TRIGGER_CHORUS_1 = 207260448U;
        static const AkUniqueID TRIGGER_CHORUS_2 = 207260451U;
        static const AkUniqueID TRIGGER_MAIN_MENU = 2876245593U;
        static const AkUniqueID TRIGGER_VERSE_1 = 4172948721U;
        static const AkUniqueID TRIGGER_VERSE_2 = 4172948722U;
        static const AkUniqueID TRIGGER_VERSE_3 = 4172948723U;
    } // namespace EVENTS

    namespace SWITCHES
    {
        namespace GRAVITY_SWITCH
        {
            static const AkUniqueID GROUP = 1165103340U;

            namespace SWITCH
            {
                static const AkUniqueID DOWN = 2280510569U;
                static const AkUniqueID UP = 1551306158U;
            } // namespace SWITCH
        } // namespace GRAVITY_SWITCH

        namespace UI_SWITCH
        {
            static const AkUniqueID GROUP = 441552802U;

            namespace SWITCH
            {
                static const AkUniqueID RETRY = 3496907717U;
                static const AkUniqueID START = 1281810935U;
                static const AkUniqueID STOP = 788884573U;
            } // namespace SWITCH
        } // namespace UI_SWITCH

    } // namespace SWITCHES

    namespace TRIGGERS
    {
        static const AkUniqueID CHORUS_1 = 1961625279U;
        static const AkUniqueID CHORUS_2 = 1961625276U;
        static const AkUniqueID MAIN_MENU = 2005704188U;
        static const AkUniqueID VERSE_1 = 1313269976U;
        static const AkUniqueID VERSE_2 = 1313269979U;
        static const AkUniqueID VERSE_3 = 1313269978U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID AMBIENCE = 85412153U;
        static const AkUniqueID ENEMY_CHARACTER = 4022354699U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID PLAYER_CHARACTER = 3570892038U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIENCE = 85412153U;
        static const AkUniqueID ENEMY_CHARACTER = 4022354699U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID PLAYER_CHARACTER = 3570892038U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
