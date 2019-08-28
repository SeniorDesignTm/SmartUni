using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BrowserOpener : MonoBehaviour {

	public Text WebLink;

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked() {
        string pageToOpen = WebLink.text;
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "AURAK";

		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}
