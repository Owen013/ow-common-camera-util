﻿using UnityEngine;
using UnityEngine.Events;

namespace CommonCameraUtil.API;

public interface ICommonCameraAPI
{
    void RegisterCustomCamera(OWCamera OWCamera);
    (OWCamera, Camera) CreateCustomCamera(string name);
    UnityEvent<PlayerTool> EquipTool();
    UnityEvent<PlayerTool> UnequipTool();
}
