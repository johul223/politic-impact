function publishStory() {
    FB.ui({
        method: 'feed',
        name: 'I\'m doing a test!', //This should be the subject of the case
        //caption: 'Hope this works', 
        description: 'Check out Facebook\'s developer site to start building.', //This should be the discription of the case
        link: 'http://annasemone.se', //This should be the page I'm on, the page of the case
        picture: 'http://annasemone.se/images/niklas2.JPG' // This should be the image of the case
    },
    function (response) {
        console.log('publishStory response: ', response);
    });
    return false;
}
/*@Scripts.Render("~/Scripts/publishStory.js")
@Scripts.Render("~/Scripts/facebookConnect.js")
<a href="#" onclick="publishStory();">Publish feed story</a><br>*/