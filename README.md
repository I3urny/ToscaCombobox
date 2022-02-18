# Tosca 15.0 Combobox Bug

## Expected behaviour
After a Combobox has its ItemsSource changed and I scan the application with Tosca 15.0, the DefaultName of each ComboboxItem is set according to its underlying TextBlock.Text property. 

## Actual behaviour 
After a Combobox has its ItemsSource changed and I scan the application with Tosca 15.0, the DefaultName of each ComboboxItem is set to something else.

## Cause 
In its current form, the ComboboxAdapterController checks if ComboboxItems are available.  
If they are, they are added to the Combobox.  
If they are not found, the Combobox is opened and then they are searched for and added to the Combobox.  
But because of how WPF works, the ComboboxItems are always there (unless some specific implementation only loads them on opening) but the underlying TextBlocks are only generated when the Combobox is initally loaded or the Combobox is opened. 

## Fix
The ComboboxAdapterController should check if there are any ComboboxItems AND any TextBlocks below it. If not, it should open the Combobox and scan the then generated Items/TextBlocks.

## Steps to reproduce

* Compile ToscaCombobox Application or use the compiled version from bin\Debug
* Start ToscaCombobox Application
* Click on "Change ItemsSource" button
* Scan ToscaCombobox Application with Tosca 15.0

## Demo
<img src="./tosca-15.0-combobox.gif?raw=true">
