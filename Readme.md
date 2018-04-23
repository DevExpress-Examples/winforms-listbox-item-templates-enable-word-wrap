# How to implement the word wrap functionality in the ListBoxControl


<p>To implement this feature, you need to handle the MeasureItem event and calculate the required height based on the items text and on the client size. Then, within the DrawItem event handler, you can manually draw item's content using the DrawString method of our TextUtils.</p>

<br/>


