# Prototype GUI Launcher for Warband Script Enhancer 2

<img src="screencap.png" alt="screencap" width="400"/>
<img src="screencap2.png" alt="screencap" width="400"/>


This is a prototype gui app intented to work with [WSE2](https://forums.taleworlds.com/index.php?threads/warband-script-enhancer-2-v1-0-6-3.384882/). The app in it's current state can interact with the config file at `~\Documents\Mount&Blade Warband WSE2\rgl_config.ini`, and edit program arguments using a gui. 


### How to add new settings to the gui

In the ConfigController project, in RglPossibleSettings, declare a new class memeber: one of SettingDefaultTrue, SettingDefaultFalse, SettingDefaultString, or SettingDefaultInt, depending on your use case.

In the InitializeSettings method of the same file, make sure to instantiate the new setting.

In ConfigForm designer, add a new UI element corresponding to your setting. This UI element can interact with the ConfigForm's rglSettings field.

### How to add command line arguments to WSE2 exe

In playLabel_click() in LaucherForm.cs, the options are passed to the wse2.exe using a CLI_Options class.

### TODO:
The app is currently in testing mode, with a debugging terminal opening with the app.

Add more ini settings that can be edited.

Add more possible language options.
