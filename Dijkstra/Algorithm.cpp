#include "Algorithm.h"
#include <limits.h>

Node^ Algorithm::getLessEgdeValue(HashSet<Node^>^ uncheckedNodes) {
	Node^ lowestDistanceNode;
	int lowestDistance = INT_MAX;
	for each (Node^ node in uncheckedNodes) {
		if (node->distance < lowestDistance) {
			lowestDistance = node->distance;
			lowestDistanceNode = node;
		}
	}
	return lowestDistanceNode;
}

void Algorithm::getPath(Node^ node, int value, Node^ predecessor) {
	int predecessorValue = predecessor->distance;
	if ((predecessorValue + value) < node->distance) {
		node->distance = predecessorValue + value;
		ArrayList^ path = gcnew ArrayList();
		path->AddRange(predecessor->path);
		path->Add(predecessor);
		node->addPath(path);
	}
}


String^ Algorithm::execute(Node^ start, Node^ end) {
	HashSet<Node^>^ checkedNodes = gcnew HashSet<Node^>();
	HashSet<Node^>^ uncheckedNodes = gcnew HashSet<Node^>();

	uncheckedNodes->Add(start);

	while (uncheckedNodes->Count != 0) {
		Node^ currentNode = getLessEgdeValue(uncheckedNodes);
		uncheckedNodes->Remove(currentNode);
		for each (KeyValuePair<Node^, int> adjacent in currentNode->adjacents) {
			if (!checkedNodes->Contains(adjacent.Key)) {
				getPath(adjacent.Key, adjacent.Value, currentNode);
				uncheckedNodes->Add(adjacent.Key);
			}
		}
		checkedNodes->Add(currentNode);
	}

	String^ result = "La ruta mas corta para llegar a " + end->name + " es: ";
	for each (Node ^ node in end->path)
		result += node->name + " - ";
	result += end->name + "\n";
	result += "El peso final es de: " + end->distance;
	return result;
}