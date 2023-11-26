switch (workStatus)
{
    case "ManagerInRoom":
        WorkDiligently();
        break;

    case "HaveNonUrgentDeadline":
    case "HaveImminentDeadline":
        CheckTwitter();
        CheckEmail();
        CheckTwitter();
        ContemplateGettingOnWithSomeWork();
        CheckTwitter();
        CheckTwitter();
        break;

    case "DeadlineOvershot":
        WorkFuriously();
        break;

    default:
        CheckTwitter();
        CheckEmail();
        break;
}
