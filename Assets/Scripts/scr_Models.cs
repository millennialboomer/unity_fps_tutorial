using System;
using System.Collections.Generic;
using UnityEngine;

public static class scr_Models
{
    #region - Player -
    public enum PlayerStance
    {
        Stand,
        Crouch,
        Prone
    }
    [Serializable]

    public class PlayerSettingsModel
    {
        [Header("View Settings")]
        public float ViewXSensitivity;
        public float ViewYSensitivity;
        
        
        public bool ViewXInverted;
        public bool ViewYInverted;
        [Header("Movement")]
        public float WalkingForwardSpeed;
        public float WalkingBackwardSpeed;
        public float WalkingStrafeSpeed;

        [Header("Jumping")]
        public float JumpingHeight;
        public float JumpingFalloff;

    }

    #endregion
}