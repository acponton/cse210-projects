using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._author = "The Church of Jesus Christ of Latter-day Saints";
        video1._lengthSeconds = 306;
        video1._title = "The Peace and Hope of Easter | President Russell M. Nelson Palm Sunday Invitation";

        Comment comment1 = new Comment();
        comment1._title = "The Peace and Hope of Easter | President Russell M. Nelson Palm Sunday Invitation";
        comment1._name = "Wishcash27";
        comment1._text = "Even if you’re not a member of the church, you can instantly feel calmed by this man.";

        Comment comment2 = new Comment();
        comment2._title = "The Peace and Hope of Easter | President Russell M. Nelson Palm Sunday Invitation";
        comment2._name = "Brittany Fisher";
        comment2._text = "So much peace comes from this man’s words";

        Comment comment3 = new Comment();
        comment3._title = "The Peace and Hope of Easter | President Russell M. Nelson Palm Sunday Invitation";
        comment3._name = "Romela Cris Penaranda";
        comment3._text = "As always, I am grateful to hear God's prophet speaking message of hope and peace";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        video1.DisplayVideosDetails();

        Console.WriteLine("");



        Video video2 = new Video();
        video2._author = "The Church of Jesus Christ of Latter-day Saints";
        video2._lengthSeconds = 135;
        video2._title = "Spiritual Whirlwinds";

        Comment comment4 = new Comment();
        comment4._title = "Spiritual Whirlwinds";
        comment4._name = "Loki Nye";
        comment4._text = "As a muslim, I find this so relatable to me and my spiritual fundamentals.";

        Comment comment5 = new Comment();
        comment5._title = "Spiritual Whirlwinds";
        comment5._name = "Missy Spivey";
        comment5._text = "I have had many whirlwinds lately. Thank you for reminding me to stand tall in my faith!";

        Comment comment6 = new Comment();
        comment6._title = "Spiritual Whirlwinds";
        comment6._name = "SuperNotGaming";
        comment6._text = "I always come back to this video for strength.I love this gospel";

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        video2.DisplayVideosDetails();
        Console.WriteLine("");



        Video video3 = new Video();
        video3._author = "The Church of Jesus Christ of Latter-day Saints";
        video3._lengthSeconds = 334;
        video3._title = "Temples Through Time";

        Comment comment7 = new Comment();
        comment7._title = "Temples Through Time";
        comment7._name = "Mystic Wolf";
        comment7._text = "This video was a touching tribute, beautifully done. I wish the Temples would reopen so I could go once again.";

        Comment comment8 = new Comment();
        comment8._title = "Temples Through Time";
        comment8._name = "Noah Young";
        comment8._text = "When I go to the temple, I feel the presence of the Lord and that he is with me all the time.";

        Comment comment9 = new Comment();
        comment9._title = "Temples Through Time";
        comment9._name = "William Allen";
        comment9._text = "Such an awesome video! Great insight into the history of temples!";

        Comment comment10 = new Comment();
        comment10._title = "Temples Through Time";
        comment10._name = "David Gillis";
        comment10._text = "The presence of the Lord in His temple has given me the strength to continue on when I felt hopeless. There is a power and a closeness to divinity there.";

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);

        video3.DisplayVideosDetails();
        Console.WriteLine("");

    }
}