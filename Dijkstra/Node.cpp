#include "Node.h"

Node::Node(String^ name, int distance) {
	this->name = name;
	this->distance = distance;
	this->path = gcnew ArrayList();
	this->adjacents = gcnew Dictionary<Node^, int>();
}

bool Node::isAdjacent(Node^ node) {
	return this->adjacents->ContainsKey(node);
}

void Node::addAdjacent(Node^ node, int distance) {
	this->adjacents[node] = distance;
}

void Node::addPath(ArrayList^ newPath) {
	this->path->Clear();
	this->path->AddRange(newPath);
}