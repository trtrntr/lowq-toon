using UnityEngine;

namespace Toon
{
    public static class Constant
    {
        public enum Sindex
        {
            Title = 0,
            Main,
            Fail,
            Clear
        }

        public static readonly string
        //------------------------------------------------------------------------------
        // SCENE NAME
        //------------------------------------------------------------------------------
        Main = "Main",
        Title = "Title",
        Clear = "Clear",
        Failure = "Over",
        TestS = "TestScene"
        ;

        //------------------------------------------------------------------------------
        // KEY NAME?
        //------------------------------------------------------------------------------
        public static readonly string
        Horizontal = "Horizontal",
        Vertical = "Vertical",
        Jump = "Jump",
        MouseX = "Mouse X",
        MouseY = "Mouse Y",
        Volume = "Volume"
        ;

        //------------------------------------------------------------------------------
        // TAG NAME
        //------------------------------------------------------------------------------
        public static readonly string
        Player = "Player2",
        Ground = "Ground",
        MainCam = "MainCamera",
        Camera = "Cam",
        Gun = "Gun",
        Missile = "Missile",
        Bullet = "Bullet",
        Manager = "Manager",
        Tower = "Towre",
        Test = "Test",
        ScriptableFile = "Scriptable",
        Portal = "Portal",
        Speaker = "Speaker",
        Enemy = "Enemy"
        ;

        public static readonly Vector3 MainGravity = new(0, -9.81f, 0);
        public static readonly KeyCode Crouch = KeyCode.C;
    }
}
// Space || A = Fire,
// LShift || B = Reload,
// WASD || LStick = Moving
