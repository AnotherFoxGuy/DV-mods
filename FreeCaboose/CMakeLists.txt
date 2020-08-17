include(CSharpUtilities)

project("FreeCaboose" VERSION 0.1.0 LANGUAGES CSharp)

add_library(${PROJECT_NAME} SHARED Main.cs)

set(MANAGED_DIR "${GAME_FOLDER}/DerailValley_Data/Managed")

set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.5")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCES_COPY_LOCAL FALSE)
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCE_UnityEngine "${MANAGED_DIR}/UnityEngine.dll")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCE_AssemblyCSharp "${MANAGED_DIR}/Assembly-CSharp.dll")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCE_UnityModManager "${MANAGED_DIR}/UnityModManager/UnityModManager.dll")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCE_Harmony "${MANAGED_DIR}/UnityModManager/0Harmony.dll")
