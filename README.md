# .NET_Wiki_CenterControl
(written by Matti 'Getschonnik' W.)

* Center a control by another control as reference. 

' To center a label, textbox or another control. 

' How to use (center a textbox on the main form):

            Center_control(Form1, textbox1)

' How to use (center a dialog box over the main form):

' Good for borderless forms..  form2.showDialog()

' Write this in the load of the dialogbox (e.g. form2)

            Center_control(Form1, me)
