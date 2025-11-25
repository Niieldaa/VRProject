using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class XRSocketTag : XRSocketInteractor
{

    public string targetTag;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        var component = interactable as Component;

        return component != null
               && component.CompareTag(targetTag)
               && base.CanSelect(interactable);
    }

}
