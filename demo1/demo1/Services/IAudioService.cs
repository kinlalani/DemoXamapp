using System;
using System.Collections.Generic;
using System.Text;

namespace demo1.Services
{
    public interface IAudioService
    {     
        void PlaySoundThroughSpeaker();

        void StopMediaPlayer();

        void StartSMSRetriver();
    }
}
