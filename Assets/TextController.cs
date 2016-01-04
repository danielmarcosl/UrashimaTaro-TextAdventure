using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {
		title, watching_turtle, watching_turtle_detected, boat_saving_turtle, boat_without_saving_turtle, boat_without_saving_turtle_detected, palace_saving_turtle,
		palace_without_saving_turtle, palace_decision, palace_stay, palace_leave, outside_01, outside_02, outside_open_box, outside_not_open_box, credits};

	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.title;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.title) {state_title ();}
		else if (myState == States.watching_turtle) {state_watching_turtle ();}
		else if (myState == States.watching_turtle_detected) {state_watching_turtle_detected ();}
		else if (myState == States.boat_saving_turtle) {state_boat_saving_turtle ();}
		else if (myState == States.boat_without_saving_turtle) {state_boat_without_saving_turtle ();}
		else if (myState == States.boat_without_saving_turtle_detected) {state_boat_without_saving_turtle_detected ();}
		else if (myState == States.palace_saving_turtle) {state_palace_saving_turtle ();}
		else if (myState == States.palace_without_saving_turtle) {state_palace_without_saving_turtle ();}
		else if (myState == States.palace_decision) {state_palace_decision ();}
		else if (myState == States.palace_stay) {state_palace_stay ();}
		else if (myState == States.palace_leave) {state_palace_leave ();}
		else if (myState == States.outside_01) {state_outside_01 ();}
		else if (myState == States.outside_02) {state_outside_02 ();}
		else if (myState == States.outside_open_box) {state_outside_open_box ();}
		else if (myState == States.outside_not_open_box) {state_outside_not_open_box ();}
		else if (myState == States.credits) {state_credits ();}

		Debug.Log (myState);
	}

	#region States

	void state_title () {
		text.text = "Urashima Taro, the folk tale\n\n" +
			"Press Space to start.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.watching_turtle;}
	}

	void state_watching_turtle () {
		text.text = "One day, a young fiherman named Urashima Taro is fishing when he notices a group of children torturing a small turtle. " +
			"They didn't notice Taro yet.\nWhat will Taro do?\n\n" + 
			"Press 1 for save the turtle.\n" +
			"Press 2 for keep watching the torture.\n" +
			"Press 3 for leave without do nothing.";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.boat_saving_turtle;}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.watching_turtle_detected;}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.boat_without_saving_turtle;}
	}

	void state_watching_turtle_detected () {
		text.text = "Taro keeps watching how the group of children turturing the small turtle. The small turtle see Taro and yells for help.\n" + 
			"What will Taro do?\n\n" +
			"Press 1 for save the turtle.\n" +
			"Press 2 for leave without do nothing.";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.boat_saving_turtle;}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.boat_without_saving_turtle_detected;}
	}

	void state_boat_saving_turtle () {
		text.text = "Taro saves the small turtle and lets it go back to the sea.\n\n" + 
			"The next day, a huge turtle approaches him and tells him that the small turtle he had saved is the daughter of the Emperor of the Sea, Ryujin, " +
			"who wants to see him to thanks him. The turtle magically gives Taro gills and brings him to the bottom of the sea, to the palace of the Dragon God.\n\n" + 
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.palace_saving_turtle;}
	}

	void state_boat_without_saving_turtle () {
		text.text = "Taro leaves without anyone notice him, and let the turtle be turtored.\n\n" +
			"The next day, a huge turtle approaches him and tells him that the small turtle he leaved without saved it was the daughther of the Emperor of the Sea, Ryujin, " +
			"who wants to torture him like him watched his daughter be tortured. The turtle magically gives Taro gills and brings him to the bottom of the sea, to the palace of the Dragon God.\n\n" +
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.palace_without_saving_turtle;}
	}

	void state_boat_without_saving_turtle_detected () {
		text.text = "Taro leaves ignoring the yells of help of the small turtle and let it be turtored.\n\n" +
			"The next day, a huge turtle approaches him and tells him that the small turtle he leaved without saved it was the daughther of the Emperor of the Sea, Ryujin, " +
			"who wants to torture him like him watched his daughter be tortured. The turtle magically gives Taro gills and brings him to the bottom of the sea, to the palace of the Dragon God.\n\n" +
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.palace_without_saving_turtle;}
	}

	void state_palace_saving_turtle () {
		text.text = "Taro meets the Emperor and the small turtle, who was now a lovely princess, Otohime, and they thanks to Taro for save her for the group of children.\n\n" +
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.palace_decision;}
	}

	void state_palace_without_saving_turtle () {
		text.text = "Taro meets the Emperor, who throws him to an abysm where a group of turtles torture him for the rest of his life.\n\n" +
			"Press Space to finish the folk tale.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.credits;}
	}

	void state_palace_decision () {
		text.text = "Taro stays in the palace with Otohime for three days, but soon wants to go back to his village and see his aging mother, so he requests permission to leave.\n\n" +
			"The princess says she is sorry if she has to see him go\nWhat will Taro do?\n\n" +
			"Press 1 for stay in the palace.\n" +
			"Press 2 for leave the palace.";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.palace_stay;} 
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.palace_leave;}
	}

	void state_palace_stay () {
		text.text = "Taro stay in the palace with Otohime, they had little turtles and live happy forever.\n\n" +
			"Press Space to finish the folk tale.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.credits;}
	}

	void state_palace_leave () {
		text.text = "The princess whises him well and gives him a mysterious box which will protect him from harm but which she tells him never to open it.\n\n" +
			"Taro grabs the box, jumps on the back of the same turtle that had brought him there, and soon is at the seashore.\n\n" +
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.outside_01;}
	}

	void state_outside_01 () {
		text.text = "When he goes home, everything has changed. His home is gone, his mother has vanished, and the people he knew are nowhere to be seen. " +
			"He asks if anybody knows a man called Urashima Taro. They answer that they had heard someone of that name had vanished at sea long ago." +
			"He discovers that 300 years have passed since the day he left for the bottom of the sea.\n\n" +
			"Press Space to continue.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.outside_02;}
	}

	void state_outside_02 () {
		text.text = "Struck by grief, he sit on a rock and remember the box that Otohime given him.\nWhat will Taro do?\n\n" +
			"Press 1 to open the box.\n"+
			"Press 2 to do not open the box.";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.outside_open_box;}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.outside_not_open_box;}
	}

	void state_outside_open_box () {
		text.text = "He absent-mindedly opens the box the princess had given him, from which bursts forth a cloud of white smoke. He is suddenly aged, his beard long and white, " +
			"and his back bent. From the sea comes the sad, sweet voice of the princess: \"I told you not to open that box. In it was your old age ...\"\n" +
			"Press Space to finish the folk tale.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.credits;}
	}

	void state_outside_not_open_box () {
		text.text = "Taro return to the bottom of the sea with Otohime, they had little turtles and live happy forever.\n\n" +
			"Press Space to finish the folk tale.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.credits;}
	}

	void state_credits () {
		text.text = "Game Developer: Daniel Marcos\n\nThanks for play it!\n\nPress Space to return to the title.";

		if (Input.GetKeyDown (KeyCode.Space)) {myState = States.title;}
	}

	#endregion States
}
