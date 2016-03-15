public enum StarRating
{ Five, Four, Three, Two, One }

var rating = StarRating.Three;
var commission = 0.0;
var perNight = 300.0;

Console.WriteLine(string.Format(
    "StarTest: {0}", StarRating.Five > rating));

switch(rating){
    case StarRating.Five:
        commission = perNight * .13;
        break;
    case StarRating.Four:
        commission = perNight * .11;
        break;
    case StarRating.Three:
        commission = perNight * .09;
        break;
    case StarRating.Two:
        commission = perNight * .07;
        break;
    default:
        commission = perNight * .05;
        break;
}

Console.WriteLine(string.Format("Commission: {0}", commission));