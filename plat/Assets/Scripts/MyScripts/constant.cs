using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Toon
{
    public static class constant
    {
        public static readonly string
        //------------------------------------------------------------------------------
        // SCENE NAME
        //------------------------------------------------------------------------------
        Main = "Main",
        Title = "Title",
        Clear = "Clear",
        Over = "Over"
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
        Player = "Player",
        Ground = "Ground",
        MainCam = "MainCamera",
        Camera = "Cam",
        Gun = "Gun",
        Missile = "Missile",
        BulletLayer = "Bullet",
        Manager = "Manager",
        Tower = "Towre"
        ;

        public static readonly Vector3 MainGravity = new(0, -9.81f, 0);
        public static readonly KeyCode Crouch = KeyCode.C;
    }
}
