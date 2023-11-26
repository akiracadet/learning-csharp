double targetVolume;

if (getOpen)
{
    targetVolume = MaxVolume;
}
else
{
    targetVolume = 0.0;
}

FadeVolume(targetVolume, FadeDuration, FadeCurce.Linear);
