﻿using MindMate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindMate.Plugins.Tasks
{
    /// <summary>
    /// used to store Target Date after task is completed
    /// </summary>
    public static class TargetDateAttribute
    {
        public const string ATTRIBUTE_NAME = "Target Date";

        /// <summary>
        /// Checks if this attribute spec exists on the given node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static bool TargetDateExists(this MapNode node)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(node.Tree);
            if (aspec != null)
                return node.ContainsAttribute(aspec);
            else
                return false;
        }

        /// <summary>
        /// Delete this attribute from the given node
        /// </summary>
        /// <param name="node"></param>
        public static void RemoveTargetDate(this MapNode node)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(node.Tree);
            if (aspec != null)
            {
                node.DeleteAttribute(aspec);
            }
        }

        private static bool GetAttribute(MapNode node, out MapNode.Attribute attribute)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(node.Tree);
            if (aspec != null)
            {
                if (node.GetAttribute(aspec, out attribute))
                {
                    return true;
                }
            }

            attribute = MapNode.Attribute.Empty;
            return false;
        }

        /// <summary>
        /// Throws exception if there is no Target Date attribute
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static DateTime GetTargetDate(this MapNode node)
        {
            MapNode.Attribute att;
            GetAttribute(node, out att);
            return DateHelper.ToDateTime(att.value);
        }

        public static void SetTargetDate(this MapNode node, DateTime value)
        {
            MapTree.AttributeSpec aspec = GetOrCreateAttributeSpec(node.Tree);
            node.AddUpdateAttribute(new MapNode.Attribute(aspec, DateHelper.ToString(value)));
        }

        public static bool IsTargetDate(this MapTree.AttributeSpec aspec)
        {
            return aspec.Name == ATTRIBUTE_NAME && aspec.Type == MapTree.AttributeType.System;
        }

        private static MapTree.AttributeSpec CreateAttributeSpec(this MapTree tree)
        {
            return new MapTree.AttributeSpec(
                tree, ATTRIBUTE_NAME, true, MapTree.AttributeDataType.DateTime,
                MapTree.AttributeListOption.NoList, null, MapTree.AttributeType.System);
        }

        private static MapTree.AttributeSpec GetAttributeSpec(MapTree tree)
        {
            MapTree.AttributeSpec aspec = tree.GetAttributeSpec(ATTRIBUTE_NAME);
            return (aspec != null && aspec.Type == MapTree.AttributeType.System) ? aspec : null;
        }

        private static MapTree.AttributeSpec GetOrCreateAttributeSpec(MapTree tree)
        {
            MapTree.AttributeSpec aspec = GetAttributeSpec(tree);
            if (aspec == null) aspec = tree.CreateAttributeSpec();

            return aspec;
        }
    }
}
