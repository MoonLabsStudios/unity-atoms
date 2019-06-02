using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color", fileName = "ColorVariable")]
    public sealed class ColorVariable : EquatableScriptableObjectVariable<Color, ColorEvent, ColorColorEvent> { }
}
