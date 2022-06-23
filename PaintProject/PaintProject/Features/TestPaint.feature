Feature: TestPaint

Scenario: UploadingAPictureEditingAndCanceling
	Given If there are open '@GetPaintDriverName()' application instances, close them
	When Open '@GetPaintDriverName()' application
	Then '@GetPaintDriverName()' application is opened
	When Upload image '@GetPathImg()'
	When Click on Select advanced
		And Choose Select All
		And Click Cut
		And Close Paint
	Then A dialog appeared with a suggestion to save the results
	When Reject result
	Then The pictures '@GetOriginalAndStorePicture()' is not different