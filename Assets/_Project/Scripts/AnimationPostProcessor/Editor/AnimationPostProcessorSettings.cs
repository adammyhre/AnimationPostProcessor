using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "AnimationPostProcessorSettings", menuName = "AnimationPostProcessor/Settings", order = 1)]
public class AnimationPostProcessorSettings : ScriptableObject {
    public bool enabled = true;
    public string targetFolder = "Assets/_Project/Animations";
    public Avatar referenceAvatar;
    public GameObject referenceFBX;
    
    public bool enableTranslationDoF = true;
    public ModelImporterAnimationType animationType = ModelImporterAnimationType.Human;
    public bool loopTime = true;
    public bool renameClips = true;
    public bool forceEditorApply = true;
    public bool extractTextures = true;
}
