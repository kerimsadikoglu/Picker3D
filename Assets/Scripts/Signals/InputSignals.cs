using Keys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Signals
{
    public class InputSignals : MonoBehaviour
    {

        #region Singleton

        public static InputSignals Instance;

        private  void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;

            }
            Instance = this;
        }

        #endregion

        public UnityAction onEnableInput = delegate { };
        public UnityAction onDisableInput = delegate { };
        public UnityAction onFirstTimeTouchTaken = delegate { };
        public UnityAction onInputTaken = delegate { };
        public UnityAction onInputReleased = delegate { };
        public UnityAction<HorizontalInputParams> onInputDragged = delegate { };

    }
}

